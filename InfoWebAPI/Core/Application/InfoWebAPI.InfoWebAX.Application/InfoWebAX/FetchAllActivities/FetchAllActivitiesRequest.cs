using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "FetchAllActivities", HttpType.Get)]
    public class FetchAllActivitiesRequest : IRequest<FetchAllActivitiesResponse>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
    }
}