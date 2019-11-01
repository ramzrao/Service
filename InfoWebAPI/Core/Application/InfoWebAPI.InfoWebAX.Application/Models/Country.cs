using Newtonsoft.Json;

namespace InfoWebAPI.InfoWebAX.Application.InfoService.Models
{
    public class Country
    {
        [JsonProperty("Country_ID")]
        public int CountryId { get; set; }

        [JsonProperty("Country_LongName")]
        public string CountryLongName { get; set; }

        [JsonProperty("Country_ISO_Code")]
        public string CountryISOCode { get; set; }

        [JsonProperty("zh-CN")]
        public string SimplifiedChineseName { get; set; }

        [JsonProperty("zh-TW")]
        public string TraditionalChineseName { get; set; }
    }
}