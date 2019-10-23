using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetBarcodesRequest : IRequest<GetBarcodesResponse>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
    }
}