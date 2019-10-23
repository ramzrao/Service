using InfoWebAPI.Common.Interfaces;
using InfoWebAPI.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace InfoWebAPI.Persistence
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly InfoWebDbContext _dbContext;

        public UserRepository(InfoWebDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public User Find(string userName, string password)
        {
            return Get(user => user.UserName == userName && user.Password == password);
        }

        public Permission GetPermission(int userId, int permissionId)
        {
            var userPermissions = from permission in _dbContext.Permissions
                                  join userPermission in _dbContext.UserPermissions on permission.PermissionID equals userPermission.PermissionID
                                  where userPermission.UserID == userId && userPermission.PermissionID == permissionId
                                  select permission;
            return userPermissions.FirstOrDefault();
        }

        public IEnumerable<Permission> GetPermissions(int userId)
        {
            return from permission in _dbContext.Permissions
                   join userPermission in _dbContext.UserPermissions on permission.PermissionID equals userPermission.PermissionID
                   where userPermission.UserID == userId
                   select permission;
        }

        public User GetUser(int userId)
        {
            return Get(user => user.UserID == userId);
        }

        public User GetUser(string userName)
        {
            return Get(user => user.UserName == userName);
        }
    }
}