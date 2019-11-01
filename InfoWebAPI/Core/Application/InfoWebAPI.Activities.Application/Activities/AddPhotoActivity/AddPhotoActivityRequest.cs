using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.Activities.Application
{
    [ApiAttribute("Activities", "AddPhotoActivity", HttpType.Post)]
    public class AddPhotoActivityRequest : IRequest<AddPhotoActivityResponse>
    {
        public int AccountId { get; set; }
        public int ShowKey { get; set; }
        public int ContactKey { get; set; }
        public int ActivityType { get; set; }
        public int GateKey { get; set; }
        public string ComputerName { get; set; }
    }
}