using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetPrintTemplateRequest : IRequest<GetPrintTemplateResponse>
    {
        public int AccountId { get; set; }
        public int TemplateId { get; set; }
    }
}