using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class AddGatePassageRequest : IRequest<AddGatePassageResponse>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
        public string GateNumber { get; set; }
    }
}