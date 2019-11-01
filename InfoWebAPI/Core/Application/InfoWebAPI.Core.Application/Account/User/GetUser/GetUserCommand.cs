using InfoWebAPI.Common.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Core.Application.User
{
    public class GetUserCommand : IRequestHandler<GetUserRequest, GetUserResponse>
    {
        private IUserRepository _userRepository;

        public GetUserCommand(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<GetUserResponse> Handle(GetUserRequest request, CancellationToken cancellationToken)
        {
            var user = _userRepository.GetUser(request.UserId);
            return Task.FromResult(new GetUserResponse()
            {
                User = user
            });
        }
    }
}