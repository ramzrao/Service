using InfoWebAPI.Domain.Entities;
using System.Collections.Generic;

namespace InfoWebAPI.Common.Interfaces
{
    public interface IUserRepository
    {
        User GetUser(int userId);

        User GetUser(string userName);

        User Find(string userName, string password);

        Permission GetPermission(int userId, int permissionId);

        IEnumerable<Permission> GetPermissions(int userId);
    }
}