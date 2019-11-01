using Newtonsoft.Json;

namespace InfoWebAPI.InfoWebAX.Application.InfoService.Models
{
    public class Locality
    {
        [JsonProperty("Suburb")]
        public string SuburbName { get; set; }

        [JsonProperty("Post Code")]
        public int PostCode { get; set; }

        [JsonProperty("State")]
        public string StateName { get; set; }

        [JsonProperty("Country")]
        public string CountryName { get; set; }
    }
}