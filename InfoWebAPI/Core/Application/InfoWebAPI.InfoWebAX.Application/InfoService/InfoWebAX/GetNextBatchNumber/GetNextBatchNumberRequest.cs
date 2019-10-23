using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetNextBatchNumberRequest : IRequest<GetNextBatchNumberResponse>
    {
        public int AccountId { get; set; }
    }
}