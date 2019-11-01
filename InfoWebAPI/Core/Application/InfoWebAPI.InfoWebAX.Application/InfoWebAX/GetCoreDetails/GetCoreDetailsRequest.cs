using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetCoreDetails", HttpType.Get)]
    public class GetCoreDetailsRequest : IRequest<GetCoreDetailsResponse>
    {
        public int AccountId { get; set; }
        public bool ActiveOnly { get; set; }
        public int RowLimit { get; set; }
        public string QueryParams { get; set; }
    }
}