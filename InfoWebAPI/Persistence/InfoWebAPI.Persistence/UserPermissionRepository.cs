using InfoWebAPI.Common.Interfaces;
using InfoWebAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace InfoWebAPI.Persistence
{

    public class UserPermissionRepository : BaseRepository<UserPermission>, IUserPermissionRepository
    {
        private readonly InfoWebDbContext _dbContext;

        public UserPermissionRepository(InfoWebDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public UserPermission GetUserPermission(int UserPermissionID)
        {
            return Get(acc => acc.UserPermissionID == UserPermissionID);
        }

        public IEnumerable<UserPermission> GetUserPermissions(int userId)
        {
            return from userPermission in _dbContext.UserPermissions
                   where userPermission.UserID == userId
                   select userPermission;
        }

        public IEnumerable<UserPermission> GetAllUserPermissions()
        {
            return GetAll();
        }

        public void AddUserPermission(UserPermission userPermission)
        {
            Add(userPermission);
        }

        public void DeleteUserPermission(UserPermission userPermission)
        {
            Remove(userPermission);
        }

        public void UpdateUserPermission(UserPermission userPermission)
        {
            Update(userPermission);
        }
    }
}
