using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetAllSessions", HttpType.Get)]
    public class GetAllSessionsRequest : IRequest<GetAllSessionsResponse>
    {
        public int AccountId { get; set; }
    }
}