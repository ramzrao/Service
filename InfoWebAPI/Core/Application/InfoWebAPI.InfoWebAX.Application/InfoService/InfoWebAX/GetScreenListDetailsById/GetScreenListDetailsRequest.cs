using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetScreenListDetailsRequest : IRequest<GetScreenListDetailsResponse>
    {
        public int AccountId { get; set; }
        public int ScreenListId { get; set; }
    }
}