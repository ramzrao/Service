using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetStatus", HttpType.Get)]
    public class GetStatusRequest : IRequest<GetStatusResponse>
    {
        public int AccountId { get; set; }
        public string Area { get; set; }
    }
}