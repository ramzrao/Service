using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetBarcodesWithoutFCNRequest : IRequest<GetBarcodesWithoutFCNResponse>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
    }
}