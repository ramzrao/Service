using InfoWebAPI.Application;
using InfoWebAPI.Application.Auth.Jwt;
using InfoWebAPI.Infrastructure;
using InfoWebAPI.Middleware;
using InfoWebAPI.Persistence;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using NSwag;
using NSwag.Generation.Processors.Security;
using System;
using System.Text;

namespace InfoServicesAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddPersistence(Configuration);
            services.AddCoreApplication(Configuration);
            services.AddInfoWebAXApplication(Configuration);
            services.AddInfraStructure(Configuration);
            services.AddCors(o => o.AddPolicy("AllowOrigin", corsBuilder =>
            {
                corsBuilder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader();
            }));
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                .AddControllersAsServices();
            services.AddHttpContextAccessor();

            services.AddOpenApiDocument(options =>
            {
                options.Title = "InfoWeb API";
                options.Version = "v1";
                options.Description = "";
                options.OperationProcessors.Add(new OperationSecurityScopeProcessor("JWT Token"));
            });

            #region Auth

            var jwtAppSettingOptions = Configuration.GetSection(nameof(JwtIssuerOptions));
            var signingKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtAppSettingOptions["SigningKey"]));
            // Configure JwtIssuerOptions
            services.Configure<JwtIssuerOptions>(options =>
            {
                options.Issuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)];
                options.Audience = jwtAppSettingOptions[nameof(JwtIssuerOptions.Audience)];
                options.SigningCredentials = new SigningCredentials(signingKey, SecurityAlgorithms.HmacSha256);
                options.ValidFor = TimeSpan.FromDays(1);
            });

            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidIssuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)],

                ValidateAudience = true,
                ValidAudience = jwtAppSettingOptions[nameof(JwtIssuerOptions.Audience)],

                ValidateIssuerSigningKey = true,
                IssuerSigningKey = signingKey,

                RequireExpirationTime = false,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero
            };

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(configureOptions =>
            {
                configureOptions.ClaimsIssuer = jwtAppSettingOptions[nameof(JwtIssuerOptions.Issuer)];
                configureOptions.TokenValidationParameters = tokenValidationParameters;
                configureOptions.SaveToken = true;
            });

            #endregion Auth
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseRouting();
            app.UseCors("AllowOrigin");
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
                app.UseHttpsRedirection();
                app.UseExceptionHandler("/Systems/Error");
                app.UseStatusCodePagesWithReExecute("/Systems/Error", "?statusCode={0}");
            }

            app.UseOpenApi(t =>
            {
                t.PostProcess = (document, request) =>
                {
                    var bearerApiSecurityScheme = new OpenApiSecurityScheme
                    {
                        Type = OpenApiSecuritySchemeType.ApiKey,
                        Name = "Authorization",
                        Description = "Copy 'Bearer ' + valid JWT token into field",
                        In = OpenApiSecurityApiKeyLocation.Header
                    };

                    document.SecurityDefinitions.Add("JWT Token", bearerApiSecurityScheme);
                };
            });

            app.UseSwaggerUi3();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseMiddleware(typeof(ErrorHandlingMiddleware));
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", "{controller}/{action}");
            });
        }
    }
}