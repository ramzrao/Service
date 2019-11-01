using InfoWebAPI.Common.Interfaces;
using InfoWebAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace InfoWebAPI.Persistence
{


    public class AccountUserRepository : BaseRepository<AccountUser>, IAccountUserRepository
    {
        private readonly InfoWebDbContext _dbContext;

        public AccountUserRepository(InfoWebDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public AccountUser GetAccountUser(int accountId,int userId)
        {
            return Get(acc => acc.AccountID == accountId && acc.UserID == userId);
        }

        public IEnumerable<AccountUser> GetAllAccountUsers()
        {
            return GetAll();
        }

        public IEnumerable<AccountUser> GetAccountUsers(int accountId)
        {
            return GetAll().Where(it => it.AccountID == accountId);
        }

        public void AddAccountUser(AccountUser accountUser)
        {
            Add(accountUser);
        }

        public void DeleteAccountUser(AccountUser accountUser)
        {
            Remove(accountUser);
        }
    }
}
