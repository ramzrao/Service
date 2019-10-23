using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class AddGatePassage2Request : IRequest<AddGatePassage2Response>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
        public string CardNumber { get; set; }
        public string GateNumber { get; set; }
        public string ComputerName { get; set; }
    }
}