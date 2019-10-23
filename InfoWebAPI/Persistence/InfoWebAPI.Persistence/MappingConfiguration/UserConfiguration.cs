using InfoWebAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfoWebAPI.Persistence.MappingConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.Property(e => e.UserID).HasColumnName("User_ID");
            builder.Property(e => e.UserName).HasColumnName("User_Name");
            builder.Property(e => e.Password).HasColumnName("User_Password");
            builder.Property(e => e.FullName).HasColumnName("User_FullName");
            builder.Property(e => e.IsActive).HasColumnName("User_ActiveYN");
            builder.Property(e => e.IsAdmin).HasColumnName("User_MasterYN");
            builder.Property(e => e.LastLoggedInDate).HasColumnName("User_LastLogon");
            builder.Property(e => e.DPID).HasColumnName("DP_ID");
        }
    }
}