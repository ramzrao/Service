using InfoWebAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfoWebAPI.Persistence.MappingConfiguration
{
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Accounts");
            builder.Property(e => e.AccountID).HasColumnName("Account_ID");
            builder.Property(e => e.AccountName).HasColumnName("Account_Name");
            builder.Property(e => e.AccountServer).HasColumnName("Account_Server");
            builder.Property(e => e.AccountShowName).HasColumnName("Account_ShowName");
            builder.Property(e => e.AccountShowNumber).HasColumnName("Account_ShowNumber");
            builder.Property(e => e.AccountShowStartDate).HasColumnName("Account_Show_Start");
            builder.Property(e => e.AccountShowEndDate).HasColumnName("Account_Show_End");
            builder.Property(e => e.AccountDBUserName).HasColumnName("Account_DBUserName");
            builder.Property(e => e.AccountDBPassword).HasColumnName("Account_DBPassword");
        }
    }
}