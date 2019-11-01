using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "DeletePrintTemplate", HttpType.Delete)]
    public class DeletePrintTemplateRequest : IRequest<DeletePrintTemplateResponse>
    {
        public int AccountId { get; set; }
        public int TemplateId { get; set; }
    }
}