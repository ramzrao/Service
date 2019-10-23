using InfoWebAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace InfoWebAPI.Persistence.MappingConfiguration
{
    public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.ToTable("Permissions");
            builder.Property(e => e.PermissionID).HasColumnName("Permission_ID");
            builder.Property(e => e.PermissionType).HasColumnName("Permission_Type");
            builder.Property(e => e.PermissionDescription).HasColumnName("Permission_Description");
            builder.Property(e => e.PermissionSection).HasColumnName("Permission_Section");
        }
    }
}