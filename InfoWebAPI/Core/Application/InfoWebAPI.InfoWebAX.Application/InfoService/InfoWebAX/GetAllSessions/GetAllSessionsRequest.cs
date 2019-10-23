using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetAllSessionsRequest : IRequest<GetAllSessionsResponse>
    {
        public int AccountId { get; set; }
    }
}