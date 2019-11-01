using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetLocalitiesBySuburb", HttpType.Get)]
    public class GetLocalitiesBySuburbRequest : IRequest<GetLocalitiesBySuburbResponse>
    {
        public int AccountId { get; set; }
        public string Country { get; set; }
        public string Suburb { get; set; }
    }
}