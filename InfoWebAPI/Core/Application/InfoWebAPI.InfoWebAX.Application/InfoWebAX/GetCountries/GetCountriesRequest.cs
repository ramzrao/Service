using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetCountries", HttpType.Get)]
    public class GetCountriesRequest : IRequest<GetCountriesResponse>
    {
    }
}