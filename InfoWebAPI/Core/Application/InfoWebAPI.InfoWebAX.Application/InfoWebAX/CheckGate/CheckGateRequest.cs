using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "CheckGate", HttpType.Get)]
    public class CheckGateRequest : IRequest<CheckGateResponse>
    {
        public int AccountId { get; set; }
        public string GateNumber { get; set; }
    }
}