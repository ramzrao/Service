using Newtonsoft.Json;

namespace InfoWebAPI.Application.InfoService.Models
{
    public class ScreenMessage
    {
        [JsonProperty("SC_ID")]
        public int ID { get; set; }

        [JsonProperty("SC_Field")]
        public string Field { get; set; }

        [JsonProperty("SC_Condition")]
        public string Condition { get; set; }

        [JsonProperty("SC_Message")]
        public string Message { get; set; }

        [JsonProperty("SC_FieldValue")]
        public string FieldValue { get; set; }

        [JsonProperty("SC_Order")]
        public int Order { get; set; }

        [JsonProperty("SC_CustomPrintURL")]
        public string CustomPrintURL { get; set; }

        [JsonProperty("SC_MessageStyle")]
        public string MessageStyle { get; set; }

        [JsonProperty("SC_PrintBadgeYN")]
        public bool IsPrintBadge { get; set; }

        [JsonProperty("SC_MessageType")]
        public string MessageType { get; set; }

        [JsonProperty("SC_BarcodePrefix")]
        public string BarcodePrefix { get; set; }

        [JsonProperty("SC_AppliesTo")]
        public string AppliesTo { get; set; }

        [JsonProperty("SC_Print4PYN")]
        public bool IsPrint4P { get; set; }

        [JsonProperty("SC_Print4EYN")]
        public bool IsPrint4E { get; set; }

        [JsonProperty("SC_Print4VYN")]
        public bool IsPrint4V { get; set; }

        [JsonProperty("SC_Print4BYN")]
        public bool IsPrint4B { get; set; }

        [JsonProperty("SC_PasswordYN")]
        public bool IsPassword { get; set; }
    }
}