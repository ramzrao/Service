namespace InfoWebAPI.Domain.Entities
{
    public class Permission
    {
        public int PermissionID { get; set; }
        public string PermissionType { get; set; }
        public string PermissionDescription { get; set; }
        public string PermissionSection { get; set; }
    }
}