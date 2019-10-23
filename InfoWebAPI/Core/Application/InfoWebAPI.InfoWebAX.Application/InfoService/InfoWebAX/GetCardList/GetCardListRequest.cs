using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetCardListRequest : IRequest<GetCardListResponse>
    {
        public int AccountId { get; set; }
    }
}