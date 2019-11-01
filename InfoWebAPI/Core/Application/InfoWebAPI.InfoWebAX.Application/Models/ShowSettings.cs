using Newtonsoft.Json;
using System;

namespace InfoWebAPI.Application.InfoService.Models
{
    public class ShowSettings
    {
        [JsonProperty("Name")]
        public string ShowName { get; set; }

        public int Number { get; set; }

        [JsonProperty("Start_Date")]
        public DateTime StartDate { get; set; }

        [JsonProperty("End_Date")]
        public DateTime EndDate { get; set; }

        [JsonProperty("Default_State")]
        public string DefaultState { get; set; }

        [JsonProperty("Default_Country")]
        public string DefaultCountry { get; set; }

        [JsonProperty("Is_Default")]
        public bool IsDefault { get; set; }

        public string Venue { get; set; }

        [JsonProperty("ADAPT_Code")]
        public string ADAPTCode { get; set; }

        [JsonProperty("Tiered_Seminars")]
        public bool IsTieredSeminars { get; set; }

        [JsonProperty("Main_Server")]
        public string MainServer { get; set; }

        [JsonProperty("Backup_Server")]
        public string BackupServer { get; set; }

        [JsonProperty("NextBatchNum")]
        public int NextBatchNumber { get; set; }

        [JsonProperty("eBadge_Codes")]
        public string EbadgeCodes { get; set; }

        [JsonProperty("Country_List")]
        public string CountryList { get; set; }

        public string AttendenceType { get; set; }
        public string CompanySearchType { get; set; }

        [JsonProperty("NFCEnabled")]
        public bool IsNFCEnabled { get; set; }

        public string NFCVisitorTypes { get; set; }
        public string NFCOtherCriteria { get; set; }
        public string NFCResponses { get; set; }
    }
}