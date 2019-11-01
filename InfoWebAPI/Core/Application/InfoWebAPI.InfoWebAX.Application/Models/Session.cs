using Newtonsoft.Json;
using System;

namespace InfoWebAPI.InfoWebAX.Application.InfoService.Models
{
    public class Session
    {
        [JsonProperty("Show_Key")]
        public int ShowKey { get; set; }

        [JsonProperty("Session_Name")]
        public string SessionName { get; set; }

        [JsonProperty("Session_Code")]
        public string SessionCode { get; set; }

        [JsonProperty("Session_Date")]
        public DateTime SessionDate { get; set; }

        [JsonProperty("Start_Time")]
        public string SessionStartTime { get; set; }

        [JsonProperty("End_Time")]
        public string SessionEndTime { get; set; }

        [JsonProperty("Score")]
        public decimal Score { get; set; }

        [JsonProperty("AllowDuplScoring")]
        public bool IsDuplicateScoreAllowed { get; set; }

        [JsonProperty("ExitFor")]
        public int ExitFor { get; set; }

        [JsonProperty("AttendingAnsCode")]
        public string AttendingAnswerCode { get; set; }

        [JsonProperty("AttendedAnsCode")]
        public string AttendedAnswerCode { get; set; }

        [JsonProperty("Room")]
        public string Room { get; set; }

        [JsonProperty("session_key")]
        public int SessionKey { get; set; }
    }
}