using Newtonsoft.Json;

namespace InfoWebAPI.InfoWebAX.Application.InfoService.Models
{
    public class Question
    {
        [JsonProperty("Answer_Code")]
        public string AnswerCode { get; set; }

        [JsonProperty("Is_Text")]
        public bool IsText { get; set; }

        [JsonProperty("Historical")]
        public bool IsHistorical { get; set; }
    }
}