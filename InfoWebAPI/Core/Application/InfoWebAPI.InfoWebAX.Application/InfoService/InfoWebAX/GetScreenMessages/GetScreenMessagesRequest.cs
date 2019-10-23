using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetScreenMessagesRequest : IRequest<GetScreenMessagesResponse>
    {
        public int AccountId { get; set; }
    }
}