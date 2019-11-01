using InfoWebAPI.Common.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Core.Application.User
{
    public class UpdateUserCommand : IRequestHandler<UpdateUserRequest, UpdateUserResponse>
    {
        private IUserRepository _userRepository;

        public UpdateUserCommand(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<UpdateUserResponse> Handle(UpdateUserRequest request, CancellationToken cancellationToken)
        {
            var user = _userRepository.GetUser(request.UserId);
            user.FullName = request.FullName;
            user.UserName = request.UserName;
            user.Password = request.Password;
            user.IsAdmin = request.IsAdmin;
            user.IsActive = request.IsActive;

            _userRepository.UpdateUser(user);
            return Task.FromResult(new UpdateUserResponse()
            {
                Success = true
            });
        }
    }
}