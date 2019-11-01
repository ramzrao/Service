using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetBatchCount", HttpType.Get)]
    public class GetBatchCountRequest : IRequest<GetBatchCountResponse>
    {
        public int AccountId { get; set; }
        public int BatchNumber { get; set; }
    }
}