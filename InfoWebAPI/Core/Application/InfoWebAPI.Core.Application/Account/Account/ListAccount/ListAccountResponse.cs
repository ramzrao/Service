using System.Collections.Generic;

namespace InfoWebAPI.Core.Application.Account
{
    public class ListAccountResponse
    {
        public List<Domain.Entities.Account> Accounts { get; set; }
    }
}