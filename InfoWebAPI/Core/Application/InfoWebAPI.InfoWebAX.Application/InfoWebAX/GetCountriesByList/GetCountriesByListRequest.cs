using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetCountriesByList", HttpType.Get)]
    public class GetCountriesByListRequest : IRequest<GetCountriesByListResponse>
    {
        public string ListName { get; set; }
    }
}