using Newtonsoft.Json;

namespace InfoWebAPI.InfoWebAX.Application.InfoService.Models
{
    public class Field
    {
        [JsonProperty("Field_ID")]
        public int FieldId { get; set; }

        [JsonProperty("Field_Name")]
        public string FieldName { get; set; }

        [JsonProperty("Field_ImportExportYN")]
        public bool IsFieldAvailableForImportExport { get; set; }
    }
}