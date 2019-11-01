using InfoWebAPI.Common.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Core.Application.AccountUser
{
    public class DeleteAccountUserCommand : IRequestHandler<DeleteAccountUserRequest, DeleteAccountUserResponse>
    {
        private IAccountUserRepository _accountUserRepository;

        public DeleteAccountUserCommand(IAccountUserRepository accountUserRepository)
        {
            _accountUserRepository = accountUserRepository;
        }

        public Task<DeleteAccountUserResponse> Handle(DeleteAccountUserRequest request, CancellationToken cancellationToken)
        {
            var accountUser = _accountUserRepository.GetAccountUser(request.AccountId, request.UserId);
            _accountUserRepository.DeleteAccountUser(accountUser);
            return Task.FromResult(new DeleteAccountUserResponse()
            {
                Success = true
            });
        }
    }
}