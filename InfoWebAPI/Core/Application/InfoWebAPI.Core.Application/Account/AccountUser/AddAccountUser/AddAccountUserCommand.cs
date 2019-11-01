using InfoWebAPI.Common.Interfaces;
using InfoWebAPI.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Core.Application.AccountUser
{
    public class AddAccountUserCommand : IRequestHandler<AddAccountUserRequest, AddAccountUserResponse>
    {
        private IAccountUserRepository _accountUserRepository;

        public AddAccountUserCommand(IAccountUserRepository accountUserRepository)
        {
            _accountUserRepository = accountUserRepository;
        }

        public Task<AddAccountUserResponse> Handle(AddAccountUserRequest request, CancellationToken cancellationToken)
        {
            _accountUserRepository.AddAccountUser(new Domain.Entities.AccountUser
            {
                AccountUserID = request.AccountId,
                UserID = request.UserId
            });
            return Task.FromResult(new AddAccountUserResponse { Success = true });
        }
    }
}