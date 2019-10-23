using System;

namespace InfoWebAPI.Domain.Entities
{
    public class User
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public DateTime LastLoggedInDate { get; set; }
        public int DPID { get; set; }
    }
}