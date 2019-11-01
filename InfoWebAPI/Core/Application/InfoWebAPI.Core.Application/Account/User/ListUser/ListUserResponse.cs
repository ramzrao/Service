using System.Collections.Generic;

namespace InfoWebAPI.Core.Application.User
{
    public class ListUserResponse
    {
        public IEnumerable<Domain.Entities.User> Users { get; set; }
    }
}