using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetLocalitiesByPostCode", HttpType.Get)]
    public class GetLocalitiesByPostCodeRequest : IRequest<GetLocalitiesByPostCodeResponse>
    {
        public int AccountId { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }
    }
}