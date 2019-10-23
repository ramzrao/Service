using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetCoreDetailsRequest : IRequest<GetCoreDetailsResponse>
    {
        public int AccountId { get; set; }
        public bool ActiveOnly { get; set; }
        public int RowLimit { get; set; }
        public string QueryParams { get; set; }
    }
}