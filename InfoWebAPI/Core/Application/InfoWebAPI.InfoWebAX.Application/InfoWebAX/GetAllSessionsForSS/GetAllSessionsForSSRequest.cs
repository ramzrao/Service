using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetAllSessionsForSS", HttpType.Get)]
    public class GetAllSessionsForSSRequest : IRequest<GetAllSessionsForSSResponse>
    {
        public int AccountId { get; set; }
    }
}