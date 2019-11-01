using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.Activities.Application
{
    [ApiAttribute("Activities", "AddDefaultActivity", HttpType.Post)]
    public class AddDefaultActivityRequest : IRequest<AddDefaultActivityResponse>
    {
        public int AccountId { get; set; }
        public int ShowKey { get; set; }
        public int ContactKey { get; set; }
        public int ActivityType { get; set; }
    }
}