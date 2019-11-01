using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "AddGatePassage", HttpType.Post)]
    public class AddGatePassageRequest : IRequest<AddGatePassageResponse>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
        public string GateNumber { get; set; }
    }
}