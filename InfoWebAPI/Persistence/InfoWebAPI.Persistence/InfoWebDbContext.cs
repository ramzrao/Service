using InfoWebAPI.Common.Interfaces;
using InfoWebAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace InfoWebAPI.Persistence
{
    public class InfoWebDbContext : DbContext, IInfoWebDbContext
    {
        public InfoWebDbContext(DbContextOptions<InfoWebDbContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<UserPermission> UserPermissions { get; set; }
        public DbSet<AccountUser> AccountUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(InfoWebDbContext).Assembly);
        }
    }
}