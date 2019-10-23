using InfoWebAPI.Common.Interfaces;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Application.UserPermission
{
    public class UserPermissionCommand : IRequestHandler<UserPermissionRequest, UserPermissionResponse>
    {
        private IUserRepository _userRepository;

        public UserPermissionCommand(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<UserPermissionResponse> Handle(UserPermissionRequest request, CancellationToken cancellationToken)
        {
            var permissions = _userRepository.GetPermissions(request.UserId);
            return Task.FromResult(new UserPermissionResponse()
            {
                UserId = request.UserId,
                Permissions = permissions.ToList()
            });
        }
    }
}