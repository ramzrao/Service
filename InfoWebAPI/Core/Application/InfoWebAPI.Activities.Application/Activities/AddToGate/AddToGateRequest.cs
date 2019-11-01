using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.Activities.Application
{
    [ApiAttribute("Activities", "AddToGate", HttpType.Post)]
    public class AddToGateRequest : IRequest<AddToGateResponse>
    {
        public int AccountId { get; set; }
        public int ShowKey { get; set; }
        public string GateNumber { get; set; }
        public string CardNumber { get; set; }
    }
}