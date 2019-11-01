using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetSessionByKey", HttpType.Get)]
    public class GetSessionByKeyRequest : IRequest<GetSessionByKeyResponse>
    {
        public int AccountId { get; set; }
        public int SessionKey { get; set; }
    }
}