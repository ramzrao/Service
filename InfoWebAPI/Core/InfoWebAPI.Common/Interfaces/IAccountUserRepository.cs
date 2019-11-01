using InfoWebAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InfoWebAPI.Common.Interfaces
{
    public interface IAccountUserRepository
    {
        void AddAccountUser(AccountUser accountUser);
        void DeleteAccountUser(AccountUser accountUser);
        AccountUser GetAccountUser(int accountId, int userId);
        IEnumerable<AccountUser> GetAllAccountUsers();
        IEnumerable<AccountUser> GetAccountUsers(int accountId);
    }
}
