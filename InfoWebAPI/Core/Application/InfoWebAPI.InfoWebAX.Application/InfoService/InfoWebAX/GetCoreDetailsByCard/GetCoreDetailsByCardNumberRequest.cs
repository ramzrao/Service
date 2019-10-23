using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetCoreDetailsByCardNumberRequest : IRequest<GetCoreDetailsByCardNumberResponse>
    {
        public int AccountId { get; set; }
        public string CardNumber { get; set; }
    }
}