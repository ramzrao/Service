using InfoWebAPI.Common.Interfaces;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Core.Application.Account
{
    public class ListAccountCommand : IRequestHandler<ListAccountRequest, ListAccountResponse>
    {
        private IAccountRepository _accountRepository;
        private IUserRepository _userRepository;

        public ListAccountCommand(IAccountRepository accountRepository, IUserRepository userRepository)
        {
            _accountRepository = accountRepository;
            _userRepository = userRepository;
        }

        public Task<ListAccountResponse> Handle(ListAccountRequest request, CancellationToken cancellationToken)
        {
            List<Domain.Entities.Account> accounts = new List<Domain.Entities.Account>();
            var user = _userRepository.GetUser(request.UserId);
            if (user != null)
            {
                if (!user.IsAdmin)
                    accounts = _accountRepository.GetAccounts(request.UserId).ToList();
                else
                    accounts = _accountRepository.GetAllAccounts().ToList();
            }
            return Task.FromResult(new ListAccountResponse()
            {
                Accounts = accounts
            });
        }
    }
}