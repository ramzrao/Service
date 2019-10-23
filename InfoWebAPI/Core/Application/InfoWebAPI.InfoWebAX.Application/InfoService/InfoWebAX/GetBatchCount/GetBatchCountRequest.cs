using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetBatchCountRequest : IRequest<GetBatchCountResponse>
    {
        public int AccountId { get; set; }
        public int BatchNumber { get; set; }
    }
}