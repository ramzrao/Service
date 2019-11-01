using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.Activities.Application
{
    [ApiAttribute("Activities", "PermanentDeleteActivityRecord", HttpType.Delete)]
    public class PermanentDeleteActivityRecordRequest : IRequest<PermanentDeleteActivityRecordResponse>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
    }
}