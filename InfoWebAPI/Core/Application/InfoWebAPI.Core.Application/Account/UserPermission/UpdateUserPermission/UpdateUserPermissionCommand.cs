using InfoWebAPI.Common.Interfaces;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Core.Application.UserPermission
{
    public class UpdateUserPermissionCommand : IRequestHandler<UpdateUserPermissionRequest, UpdateUserPermissionResponse>
    {
        private IUserPermissionRepository _userPermissionRepository;

        public UpdateUserPermissionCommand(IUserPermissionRepository userPermissionRepository)
        {
            _userPermissionRepository = userPermissionRepository;
        }

        public Task<UpdateUserPermissionResponse> Handle(UpdateUserPermissionRequest request, CancellationToken cancellationToken)
        {
            var permission = _userPermissionRepository.GetUserPermissions(request.UserId).Where(it => it.PermissionID == request.PermissionId).FirstOrDefault();
            if (permission != null)
            {
                permission.UserPermissionValue = request.PermissionValue;
                _userPermissionRepository.UpdateUserPermission(permission);
            }
            else
            {
                _userPermissionRepository.AddUserPermission(new Domain.Entities.UserPermission
                {
                    UserID = request.UserId,
                    PermissionID = request.PermissionId,
                    UserPermissionValue = request.PermissionValue
                });
            }
            return Task.FromResult(new UpdateUserPermissionResponse()
            {
                Success = true
            });
        }
    }
}