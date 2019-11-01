using InfoWebAPI.Common.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Core.Application.Account
{
    public class GetAccountCommand : IRequestHandler<GetAccountRequest, GetAccountResponse>
    {
        private IAccountRepository _accountRepository;

        public GetAccountCommand(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public Task<GetAccountResponse> Handle(GetAccountRequest request, CancellationToken cancellationToken)
        {
            if (request.AccountId > 0)
            {
                var account = _accountRepository.GetAccount(request.AccountId);
                return Task.FromResult(new GetAccountResponse()
                {
                    Account = account
                });
            }
            else
                return Task.FromResult(new GetAccountResponse());
        }
    }
}