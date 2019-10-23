using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class AddPrintFieldRequest : IRequest<AddPrintFieldResponse>
    {
        public int AccountId { get; set; }
        public int TemplateId { get; set; }
        public int FieldId { get; set; }
        public int FieldType { get; set; }
        public string FieldName { get; set; }
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int CharHeight { get; set; }
        public int CharWidth { get; set; }
        public string Justification { get; set; }
        public string FontFamily { get; set; }
        public int FontSize { get; set; }
        public int Style { get; set; }
        public string TextString { get; set; }
        public int MaxLength { get; set; }
        public int FieldCasing { get; set; }
        public bool IsBarcode { get; set; }
        public int MaxLines { get; set; }
        public int Rotation { get; set; }
    }
}