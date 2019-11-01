using InfoWebAPI.Common.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Core.Application.User
{
    public class AddUserCommand : IRequestHandler<AddUserRequest, AddUserResponse>
    {
        private IUserRepository _userRepository;

        public AddUserCommand(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<AddUserResponse> Handle(AddUserRequest request, CancellationToken cancellationToken)
        {
            var user = new Domain.Entities.User()
            {
                FullName = request.FullName,
                UserName = request.UserName,
                Password = request.Password,
                IsAdmin = request.IsAdmin,
                IsActive = true
            };
            _userRepository.AddUser(user);
            return Task.FromResult(new AddUserResponse()
            {
                Success = true
            });
        }
    }
}