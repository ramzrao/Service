using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "UpdatePrintTemplate", HttpType.Post)]
    public class UpdatePrintTemplateRequest : IRequest<UpdatePrintTemplateResponse>
    {
        public int AccountId { get; set; }
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

        public int TemplateId { get; set; }
        public string DefaultPrinter { get; set; }
        public string FontName { get; set; }
    }
}