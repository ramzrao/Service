using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.Activities.Application
{
    [ApiAttribute("Activities", "AddDBMSActivity", HttpType.Post)]
    public class AddDBMSRequest : IRequest<AddDBMSResponse>
    {
        public int AccountId { get; set; }
        public int ShowKey { get; set; }
        public int ContactKey { get; set; }
        public int ActivityType { get; set; }
        public string ActivityUsername { get; set; }
    }
}