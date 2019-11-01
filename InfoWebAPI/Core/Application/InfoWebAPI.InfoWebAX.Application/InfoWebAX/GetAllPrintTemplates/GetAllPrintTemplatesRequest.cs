using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetAllPrintTemplates", HttpType.Get)]
    public class GetAllPrintTemplatesRequest : IRequest<GetAllPrintTemplatesResponse>
    {
        public int AccountId { get; set; }
    }
}