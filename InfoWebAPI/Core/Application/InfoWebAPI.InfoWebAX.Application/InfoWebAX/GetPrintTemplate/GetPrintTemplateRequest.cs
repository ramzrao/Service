using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetPrintTemplate", HttpType.Get)]
    public class GetPrintTemplateRequest : IRequest<GetPrintTemplateResponse>
    {
        public int AccountId { get; set; }
        public int TemplateId { get; set; }
    }
}