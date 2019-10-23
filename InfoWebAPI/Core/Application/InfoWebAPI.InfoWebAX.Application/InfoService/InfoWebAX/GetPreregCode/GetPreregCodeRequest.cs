using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetPreregCodeRequest : IRequest<GetPreregCodeResponse>
    {
        public int AccountId { get; set; }
    }
}