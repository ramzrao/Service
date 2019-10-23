using InfoWebAPI.Domain.Entities;
using System.Collections.Generic;

namespace InfoWebAPI.Common.Interfaces
{
    public interface IAccountRepository
    {
        Account GetAccount(int accountId);

        IEnumerable<Account> GetAccounts(int userId);

        IEnumerable<Account> GetAllAccounts();
    }
}