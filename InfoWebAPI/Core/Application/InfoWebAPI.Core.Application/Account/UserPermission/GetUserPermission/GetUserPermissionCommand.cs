using InfoWebAPI.Common.Interfaces;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Core.Application.UserPermission
{
    public class GetUserPermissionCommand : IRequestHandler<GetUserPermissionRequest, GetUserPermissionResponse>
    {
        private IUserRepository _userRepository;

        public GetUserPermissionCommand(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<GetUserPermissionResponse> Handle(GetUserPermissionRequest request, CancellationToken cancellationToken)
        {
            var permissions = _userRepository.GetPermissions(request.UserId);
            return Task.FromResult(new GetUserPermissionResponse()
            {
                UserId = request.UserId,
                Permissions = permissions.ToList()
            });
        }
    }
}