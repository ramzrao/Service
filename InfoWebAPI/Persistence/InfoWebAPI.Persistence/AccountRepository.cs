using InfoWebAPI.Common.Interfaces;
using InfoWebAPI.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace InfoWebAPI.Persistence
{
    public class AccountRepository : BaseRepository<Account>, IAccountRepository
    {
        private readonly InfoWebDbContext _dbContext;

        public AccountRepository(InfoWebDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public Account GetAccount(int accountId)
        {
            return Get(acc => acc.AccountID == accountId);
        }

        public IEnumerable<Account> GetAccounts(int userId)
        {
            return from account in _dbContext.Accounts
                   join accountUser in _dbContext.AccountUsers on account.AccountID equals accountUser.AccountID
                   where accountUser.UserID == userId
                   select account;
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            return GetAll();
        }
    }
}