using InfoWebAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfoWebAPI.Persistence.MappingConfiguration
{
    public class UserPermissionConfiguration : IEntityTypeConfiguration<UserPermission>
    {
        public void Configure(EntityTypeBuilder<UserPermission> builder)
        {
            builder.ToTable("UserPermission");
            builder.Property(e => e.UserPermissionID).HasColumnName("UP_ID");
            builder.Property(e => e.PermissionID).HasColumnName("UP_Permission_ID");
            builder.Property(e => e.UserID).HasColumnName("UP_User_ID");
            builder.Property(e => e.UserPermissionValue).HasColumnName("UP_Value");
        }
    }
}