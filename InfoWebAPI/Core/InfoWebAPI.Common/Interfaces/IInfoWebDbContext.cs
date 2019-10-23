using InfoWebAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InfoWebAPI.Common.Interfaces
{
    public interface IInfoWebDbContext
    {
        DbSet<Account> Accounts { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<Permission> Permissions { get; set; }
        DbSet<UserPermission> UserPermissions { get; set; }
        DbSet<AccountUser> AccountUsers { get; set; }
    }
}