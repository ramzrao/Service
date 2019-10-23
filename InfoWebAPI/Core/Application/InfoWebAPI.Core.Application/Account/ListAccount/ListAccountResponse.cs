using InfoWebAPI.Domain.Entities;
using System.Collections.Generic;

namespace InfoWebAPI.Application.ListAccount
{
    public class ListAccountResponse
    {
        public List<Account> Accounts { get; set; }
    }
}