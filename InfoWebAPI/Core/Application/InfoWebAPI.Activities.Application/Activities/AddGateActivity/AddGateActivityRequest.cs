using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.Activities.Application
{
    [ApiAttribute("Activities", "AddGateActivity", HttpType.Post)]
    public class AddGateActivityRequest : IRequest<AddGateActivityResponse>
    {
        public int AccountId { get; set; }
        public int GateKey { get; set; }
        public int ContactKey { get; set; }
    }
}