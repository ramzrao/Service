using System;

namespace InfoWebAPI.Domain.Entities
{
    public class Account
    {
        public int AccountID { get; set; }
        public string AccountServer { get; set; }
        public string AccountName { get; set; }
        public string AccountShowName { get; set; }
        public DateTime AccountShowStartDate { get; set; }
        public DateTime AccountShowEndDate { get; set; }
        public string AccountShowNumber { get; set; }
        public string AccountDBUserName { get; set; }
        public string AccountDBPassword { get; set; }
    }
}