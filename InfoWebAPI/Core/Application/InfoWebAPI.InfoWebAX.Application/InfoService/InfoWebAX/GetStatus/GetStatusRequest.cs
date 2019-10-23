using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetStatusRequest : IRequest<GetStatusResponse>
    {
        public int AccountId { get; set; }
        public string Area { get; set; }
    }
}