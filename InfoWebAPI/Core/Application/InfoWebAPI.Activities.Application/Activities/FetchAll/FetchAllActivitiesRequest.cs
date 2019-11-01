using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.Activities.Application
{
    [ApiAttribute("Activities", "FetchAll", HttpType.Get)]
    public class FetchAllActivitiesRequest : IRequest<FetchAllActivitiesResponse>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
    }
}