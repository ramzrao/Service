using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetCoreDetailsByCardNumber", HttpType.Get)]
    public class GetCoreDetailsByCardNumberRequest : IRequest<GetCoreDetailsByCardNumberResponse>
    {
        public int AccountId { get; set; }
        public string CardNumber { get; set; }
    }
}