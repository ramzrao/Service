using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetShowSettingsRequest : IRequest<GetShowSettingsResponse>
    {
        public int AccountId { get; set; }
    }
}