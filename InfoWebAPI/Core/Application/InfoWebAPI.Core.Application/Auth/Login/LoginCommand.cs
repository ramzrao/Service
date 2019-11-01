using InfoWebAPI.Application.Auth.Jwt;
using InfoWebAPI.Application.Auth.Login;
using InfoWebAPI.Common.Interfaces;
using InfoWebAPI.Core.Application.UserPermission;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Auth.Login
{
    public class LoginCommand : IRequestHandler<LoginRequest, LoginResponse>
    {
        private IUserRepository _userRepository;
        private IJwtFactory _jwtFactory;
        private readonly IMediator _mediator;

        public LoginCommand(IUserRepository userRepository, IJwtFactory jwtFactory, IMediator mediator)
        {
            _userRepository = userRepository;
            _jwtFactory = jwtFactory;
            _mediator = mediator;
        }

        public async Task<LoginResponse> Handle(LoginRequest request, CancellationToken cancellationToken)
        {
            var user = _userRepository.Find(request.UserName, request.Password);
            if (user == null)
                return await Task.FromResult(new LoginResponse
                {
                    ErrorMessage = "User Not Found",
                    IsSuccessful = false
                });
            var accessToken = await _jwtFactory.GenerateEncodedToken(user.UserName);
            var permissions = await _mediator.Send(new GetUserPermissionRequest { UserId = user.UserID });
            return await Task.FromResult(new LoginResponse
            {
                AccessToken = accessToken,
                IsSuccessful = true,
                UserPermissions = permissions.Permissions,
                UserId = user.UserID
            });
        }
    }
}