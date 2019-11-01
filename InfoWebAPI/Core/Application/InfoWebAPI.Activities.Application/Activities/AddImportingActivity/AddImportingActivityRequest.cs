using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.Activities.Application
{
    [ApiAttribute("Activities", "AddImportingActivity", HttpType.Post)]
    public class AddImportingActivityRequest : IRequest<AddImportingActivityResponse>
    {
        public int AccountId { get; set; }
        public int ShowKey { get; set; }
        public int ContactKey { get; set; }
        public int ActivityType { get; set; }
        public int ImportBatch { get; set; }
    }
}