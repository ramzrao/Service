using Newtonsoft.Json;

namespace InfoWebAPI.InfoWebAX.Application.InfoService.Models
{
    public class Gate
    {
        [JsonProperty("GateID")]
        public int GateId { get; set; }

        [JsonProperty("ListID")]
        public int ListId { get; set; }
    }
}