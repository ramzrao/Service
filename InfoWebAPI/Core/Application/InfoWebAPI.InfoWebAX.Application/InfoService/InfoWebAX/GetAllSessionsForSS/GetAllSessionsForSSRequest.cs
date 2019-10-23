using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetAllSessionsForSSRequest : IRequest<GetAllSessionsForSSResponse>
    {
        public int AccountId { get; set; }
    }
}