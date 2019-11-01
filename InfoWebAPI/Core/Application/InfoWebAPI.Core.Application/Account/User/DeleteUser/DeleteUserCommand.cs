using InfoWebAPI.Common.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Core.Application.User
{
    public class DeleteUserCommand : IRequestHandler<DeleteUserRequest, DeleteUserResponse>
    {
        private IUserRepository _userRepository;

        public DeleteUserCommand(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<DeleteUserResponse> Handle(DeleteUserRequest request, CancellationToken cancellationToken)
        {
            var user = _userRepository.GetUser(request.UserId);
            _userRepository.DeleteUser(user);
            return Task.FromResult(new DeleteUserResponse()
            {
                Success = true
            });
        }
    }
}