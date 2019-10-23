using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class CheckGateRequest : IRequest<CheckGateResponse>
    {
        public int AccountId { get; set; }
        public string GateNumber { get; set; }
    }
}