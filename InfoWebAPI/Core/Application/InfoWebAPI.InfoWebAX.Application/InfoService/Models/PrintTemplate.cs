using Newtonsoft.Json;

namespace InfoWebAPI.Application.InfoService.Models
{
    public class PrintTemplate
    {
        [JsonProperty("Print_Template_Key")]
        public int TemplateKey { get; set; }

        [JsonProperty("Name")]
        public string TemplateName { get; set; }
    }
}