using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.Activities.Application
{
    [ApiAttribute("Activities", "RestoreActivityRecord", HttpType.Post)]
    public class RestoreActivityRecordRequest : IRequest<RestoreActivityRecordResponse>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
    }
}