using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetNextBatchNumber", HttpType.Get)]
    public class GetNextBatchNumberRequest : IRequest<GetNextBatchNumberResponse>
    {
        public int AccountId { get; set; }
    }
}