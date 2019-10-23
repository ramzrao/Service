using FluentValidation;
using MediatR;

namespace InfoWebAPI.Application.Auth.Login
{
    public class LoginRequest : IRequest<LoginResponse>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class LoginRequestValidator : AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(e => e.UserName)
                .NotEmpty();

            RuleFor(e => e.Password)
                .NotEmpty();
        }
    }
}