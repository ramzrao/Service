using InfoWebAPI.Domain.Entities;
using System.Collections.Generic;

namespace InfoWebAPI.Common.Interfaces
{
    public interface IUserRepository
    {
        void AddUser(User user);
        void DeleteUser(User user);
        User Find(string userName, string password);
        Permission GetPermission(int userId, int permissionId);
        IEnumerable<Permission> GetPermissions(int userId);
        User GetUser(int userId);
        User GetUser(string userName);
        void UpdateUser(User user);
        IEnumerable<User> GetAllUsers();
    }
}