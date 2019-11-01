using InfoWebAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfoWebAPI.Common.Interfaces
{
    public interface IUserPermissionRepository
    {
        void AddUserPermission(UserPermission userPermission);
        void DeleteUserPermission(UserPermission userPermission);
        IEnumerable<UserPermission> GetAllUserPermissions();
        UserPermission GetUserPermission(int UserPermissionID);
        IEnumerable<UserPermission> GetUserPermissions(int userId);
        void UpdateUserPermission(UserPermission userPermission);
    }
}
