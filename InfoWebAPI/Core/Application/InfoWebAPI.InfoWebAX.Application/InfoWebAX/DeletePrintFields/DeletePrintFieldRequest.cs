using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class DeletePrintFieldRequest : IRequest<DeletePrintFieldResponse>
    {
        public int AccountId { get; set; }
        public int TemplateId { get; set; }
    }
}