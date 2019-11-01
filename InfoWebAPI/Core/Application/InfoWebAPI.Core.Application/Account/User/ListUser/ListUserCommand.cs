using InfoWebAPI.Common.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Core.Application.User
{
    public class ListUserCommand : IRequestHandler<ListUserRequest, ListUserResponse>
    {
        private IUserRepository _userRepository;

        public ListUserCommand(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<ListUserResponse> Handle(ListUserRequest request, CancellationToken cancellationToken)
        {
            var users = _userRepository.GetAllUsers();
            return Task.FromResult(new ListUserResponse()
            {
                Users = users
            });
        }
    }
}