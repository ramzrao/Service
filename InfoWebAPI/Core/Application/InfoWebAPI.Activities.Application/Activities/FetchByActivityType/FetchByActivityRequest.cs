using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.Activities.Application
{
    [ApiAttribute("Activities", "FetchByActivity", HttpType.Get)]
    public class FetchByActivityRequest : IRequest<FetchByActivityResponse>
    {
        public int AccountId { get; set; }
        public int ActivityType { get; set; }
    }
}