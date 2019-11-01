using Newtonsoft.Json;

namespace InfoWebAPI.InfoWebAX.Application.InfoService.Models
{
    public class ScreenListDetail
    {
        [JsonProperty("LDId")]
        public int ListDetailId { get; set; }

        [JsonProperty("LDFieldType")]
        public string FieldType { get; set; }

        [JsonProperty("LDOperator")]
        public string Operator { get; set; }

        [JsonProperty("LDFieldValue")]
        public string FieldValue { get; set; }

        public int ListId { get; set; }
    }
}