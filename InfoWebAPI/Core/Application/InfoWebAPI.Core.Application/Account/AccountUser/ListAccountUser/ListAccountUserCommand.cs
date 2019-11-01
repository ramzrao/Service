using InfoWebAPI.Common.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Core.Application.AccountUser
{
    public class ListAccountUserCommand : IRequestHandler<ListAccountUserRequest, ListAccountUserResponse>
    {
        private IAccountUserRepository _accountUserRepository;

        public ListAccountUserCommand(IAccountUserRepository accountUserRepository)
        {
            _accountUserRepository = accountUserRepository;
        }

        public Task<ListAccountUserResponse> Handle(ListAccountUserRequest request, CancellationToken cancellationToken)
        {
            var accountUsers = _accountUserRepository.GetAccountUsers(request.AccountId);
            return Task.FromResult(new ListAccountUserResponse()
            {
                AccountUsers = accountUsers
            });
        }
    }
}