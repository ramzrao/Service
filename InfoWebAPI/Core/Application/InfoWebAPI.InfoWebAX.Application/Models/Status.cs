namespace InfoWebAPI.Application.InfoService.Models
{
    public class Status
    {
        public string Message { get; set; }
        public bool CanPrint { get; set; }
        public string CustomPrintURL { get; set; }
        public string IsPasswordProtected { get; set; }
    }
}