using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetAllPrintTemplatesRequest : IRequest<GetAllPrintTemplatesResponse>
    {
        public int AccountId { get; set; }
    }
}