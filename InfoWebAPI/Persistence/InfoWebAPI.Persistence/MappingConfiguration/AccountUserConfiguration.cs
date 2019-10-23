using InfoWebAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfoWebAPI.Persistence.MappingConfiguration
{
    public class AccountUserConfiguration : IEntityTypeConfiguration<AccountUser>
    {
        public void Configure(EntityTypeBuilder<AccountUser> builder)
        {
            builder.ToTable("AccountUsers");
            builder.Property(e => e.AccountUserID).HasColumnName("AU_ID");
            builder.Property(e => e.UserID).HasColumnName("AU_User_ID");
            builder.Property(e => e.AccountID).HasColumnName("AU_Account_ID");
        }
    }
}