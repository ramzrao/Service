using InfoWebAPI.Domain.Entities;
using System.Collections.Generic;

namespace InfoWebAPI.Core.Application.UserPermission
{
    public class GetUserPermissionResponse
    {
        public int UserId { get; set; }
        public List<Permission> Permissions { get; set; }
    }
}