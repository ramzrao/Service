using InfoWebAPI.Domain.Entities;
using System.Collections.Generic;

namespace InfoWebAPI.Application.UserPermission
{
    public class UserPermissionResponse
    {
        public int UserId { get; set; }
        public List<Permission> Permissions { get; set; }
    }
}