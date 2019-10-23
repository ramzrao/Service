using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GeSessionByKeyRequest : IRequest<GeSessionByKeyResponse>
    {
        public int AccountId { get; set; }
        public int SessionKey { get; set; }
    }
}