using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class DeletePrintFieldRequest : IRequest<DeletePrintFieldResponse>
    {
        public int AccountId { get; set; }
        public int TemplateId { get; set; }
    }
}