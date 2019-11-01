using Newtonsoft.Json;
using System;

namespace InfoWebAPI.InfoWebAX.Application.InfoService.Models
{
    public class Activity
    {
        [JsonProperty("Activity_ID")]
        public int ActivityId { get; set; }

        [JsonProperty("Contact_Key")]
        public int ContactKey { get; set; }

        [JsonProperty("Activity_Type")]
        public int ActivityType { get; set; }

        [JsonProperty("Date")]
        public DateTime ActivityDate { get; set; }

        [JsonProperty("Activity_Username")]
        public string ActivityUserName { get; set; }

        [JsonProperty("ImportBatch")]
        public int ImportBatch { get; set; }

        [JsonProperty("ComputerName")]
        public string ComputerName { get; set; }

        [JsonProperty("ActivityDesc")]
        public string ActivityDescription { get; set; }
    }
}