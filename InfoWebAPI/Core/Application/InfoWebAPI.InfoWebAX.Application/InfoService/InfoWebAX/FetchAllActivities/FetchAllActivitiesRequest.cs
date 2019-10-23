using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class FetchAllActivitiesRequest : IRequest<FetchAllActivitiesResponse>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
    }
}