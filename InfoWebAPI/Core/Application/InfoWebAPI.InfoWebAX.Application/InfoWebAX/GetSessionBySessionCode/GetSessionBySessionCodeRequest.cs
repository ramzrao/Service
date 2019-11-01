using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetSessionBySessionCode", HttpType.Get)]
    public class GetSessionBySessionCodeRequest : IRequest<GetSessionBySessionCodeResponse>
    {
        public int AccountId { get; set; }
        public string SessionCode { get; set; }
    }
}