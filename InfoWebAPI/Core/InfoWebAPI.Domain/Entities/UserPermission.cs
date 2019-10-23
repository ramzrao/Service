namespace InfoWebAPI.Domain.Entities
{
    public class UserPermission
    {
        public int UserPermissionID { get; set; }
        public int PermissionID { get; set; }
        public int UserID { get; set; }
        public bool UserPermissionValue { get; set; }
    }
}