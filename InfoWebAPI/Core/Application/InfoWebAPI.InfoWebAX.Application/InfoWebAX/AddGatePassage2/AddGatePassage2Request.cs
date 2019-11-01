using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "AddGatePassage2", HttpType.Post)]
    public class AddGatePassage2Request : IRequest<AddGatePassage2Response>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
        public string CardNumber { get; set; }
        public string GateNumber { get; set; }
        public string ComputerName { get; set; }
    }
}