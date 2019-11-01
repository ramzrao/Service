using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "SearchAddress", HttpType.Get)]
    public class SearchAddressRequest : IRequest<SearchAddressResponse>
    {
        public string SearchText { get; set; }
        public string Moniker { get; set; }
        public string DisplayTextArray { get; set; }
    }
}