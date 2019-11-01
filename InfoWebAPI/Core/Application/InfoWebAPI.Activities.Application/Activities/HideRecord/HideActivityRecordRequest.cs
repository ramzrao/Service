using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.Activities.Application
{
    [ApiAttribute("Activities", "HideActivityRecord", HttpType.Post)]
    public class HideActivityRecordRequest : IRequest<HideActivityRecordResponse>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
    }
}