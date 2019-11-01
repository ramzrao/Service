using InfoWebAPI.Common.Interfaces;
using InfoWebAPI.Domain.Entities;
using System;
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
                                  where userPermission.UserID == userId && userPermission.PermissionID == permissionId && userPermission.UserPermissionValue
                                  select permission;
            return userPermissions.FirstOrDefault();
        }

        public IEnumerable<Permission> GetPermissions(int userId)
        {
            return from permission in _dbContext.Permissions
                   join userPermission in _dbContext.UserPermissions on permission.PermissionID equals userPermission.PermissionID
                   where userPermission.UserID == userId && userPermission.UserPermissionValue
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

        public void AddUser(User user)
        {
            Add(user);
        }

        public void DeleteUser(User user)
        {
            using (var transaction = _dbContext.Database.BeginTransaction())
            {
                try
                {
                    var userPermission = _dbContext.UserPermissions.Where(it => it.UserID == user.UserID).FirstOrDefault();
                    _dbContext.UserPermissions.Remove(userPermission);
                    _dbContext.SaveChanges();

                    var accountUser = _dbContext.AccountUsers.Where(it => it.UserID == user.UserID).FirstOrDefault();
                    _dbContext.AccountUsers.Remove(accountUser);
                    _dbContext.SaveChanges();

                    _dbContext.Users.Remove(user);
                    _dbContext.SaveChanges();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void UpdateUser(User user)
        {
            Update(user);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return GetAll();
        }
    }
}