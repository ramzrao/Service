using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetCardList", HttpType.Get)]
    public class GetCardListRequest : IRequest<GetCardListResponse>
    {
        public int AccountId { get; set; }
    }
}