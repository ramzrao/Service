using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetSessionBySessionCodeRequest : IRequest<GetSessionBySessionCodeResponse>
    {
        public int AccountId { get; set; }
        public string SessionCode { get; set; }
    }
}