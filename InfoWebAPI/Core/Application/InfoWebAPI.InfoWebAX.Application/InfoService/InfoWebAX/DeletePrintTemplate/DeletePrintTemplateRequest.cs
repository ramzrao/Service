using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class DeletePrintTemplateRequest : IRequest<DeletePrintTemplateResponse>
    {
        public int AccountId { get; set; }
        public int TemplateId { get; set; }
    }
}