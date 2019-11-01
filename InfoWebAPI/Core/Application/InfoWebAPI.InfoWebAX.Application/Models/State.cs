using Newtonsoft.Json;

namespace InfoWebAPI.InfoWebAX.Application.InfoService.Models
{
    public class State
    {
        [JsonProperty("Region_ID")]
        public int RegionId { get; set; }

        [JsonProperty("Region_Name")]
        public string RegionName { get; set; }

        [JsonProperty("Region_AbbrName")]
        public string RegionAbbrName { get; set; }

        [JsonProperty("Region_Country_ISO_Code")]
        public string CountryISOCode { get; set; }

        [JsonProperty("Region_AreaCode")]
        public int RegionAreaCode { get; set; }

        [JsonProperty("Region_Country_LongName")]
        public string CountryLongName { get; set; }
    }
}