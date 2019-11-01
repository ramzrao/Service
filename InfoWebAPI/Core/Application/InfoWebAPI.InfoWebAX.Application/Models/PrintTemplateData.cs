using Newtonsoft.Json;

namespace InfoWebAPI.Application.InfoService.Models
{
    public class PrintTemplateData
    {
        [JsonProperty("Print_Template_Key")]
        public int PrintTemplateKey { get; set; }

        public string Name { get; set; }
        public int LabelLength { get; set; }
        public string PrinterType { get; set; }
        public string BadgeStock { get; set; }
        public string Description { get; set; }
        public bool IsDefault { get; set; }
        public string MeasurementUnit { get; set; }
        public string PageOrientation { get; set; }
        public decimal MarginLeft { get; set; }
        public decimal MarginRight { get; set; }
        public decimal MarginTop { get; set; }
        public decimal MarginBottom { get; set; }
        public decimal BadgeWidth { get; set; }
        public decimal BadgeHeight { get; set; }

        [JsonProperty("Owner_Template_ID")]
        public int OwnerTemplateId { get; set; }

        [JsonProperty("Field_ID")]
        public int FieldId { get; set; }

        public int Type { get; set; }

        [JsonProperty("Field_Name")]
        public string FieldName { get; set; }

        [JsonProperty("Field_Top")]
        public int FieldTop { get; set; }

        [JsonProperty("Field_Left")]
        public int FieldLeft { get; set; }

        [JsonProperty("Field_Width")]
        public int FieldWidth { get; set; }

        [JsonProperty("Char_Height")]
        public int CharHeight { get; set; }

        [JsonProperty("Char_Width")]
        public int CharWidth { get; set; }

        public string Justification { get; set; }

        [JsonProperty("Multi_Use_Str")]
        public string MultiUseStr { get; set; }

        public int MaxLen { get; set; }

        [JsonProperty("Want_Upper_Case")]
        public int IsUpperCase { get; set; }

        [JsonProperty("Want_BarCode")]
        public bool IsBarcode { get; set; }

        public int MaxLines { get; set; }
        public int Rotation { get; set; }
        public int Style { get; set; }
        public string Font { get; set; }

        [JsonProperty("Font_Size")]
        public int FontSize { get; set; }

        public int PageNumber { get; set; }
        public string DefaultPrinter { get; set; }
        public string FontName { get; set; }
        public string Barcode { get; set; }
        public string PrintableText { get; set; }
    }
}