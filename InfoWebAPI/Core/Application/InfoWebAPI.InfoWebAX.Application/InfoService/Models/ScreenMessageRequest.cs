namespace InfoWebAPI.Application.InfoService.Models
{
    public class ScreenMessageRequest
    {
        public int ID { get; set; }
        public string Field { get; set; }
        public string Condition { get; set; }
        public string Message { get; set; }
        public string FieldValue { get; set; }
        public int Order { get; set; }
        public string CustomPrintURL { get; set; }
        public string MessageStyle { get; set; }
        public bool IsPrintBadge { get; set; }
        public string MessageType { get; set; }
        public string BarcodePrefix { get; set; }
        public string AppliesTo { get; set; }
        public bool IsPrint4P { get; set; }
        public bool IsPrint4E { get; set; }
        public bool IsPrint4V { get; set; }
        public bool IsPrint4B { get; set; }
        public bool IsPassword { get; set; }
    }
}