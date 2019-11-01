using InfoWebAPI.Domain.Entities;
using System.Collections.Generic;

namespace InfoWebAPI.Core.Application.AccountUser
{
    public class ListAccountUserResponse
    {
        public IEnumerable<Domain.Entities.AccountUser> AccountUsers { get; set; }
    }
}