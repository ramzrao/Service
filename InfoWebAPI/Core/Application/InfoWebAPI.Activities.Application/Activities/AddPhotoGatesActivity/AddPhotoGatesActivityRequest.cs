using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.Activities.Application
{
    [ApiAttribute("Activities", "AddPhotoGatesActivity", HttpType.Post)]
    public class AddPhotoGatesActivityRequest : IRequest<AddPhotoGatesActivityResponse>
    {
        public int AccountId { get; set; }
        public int GateKey { get; set; }
        public int ContactKey { get; set; }
        public bool IsPhotoGate { get; set; }
        public string ComputerName { get; set; }
        public int GatePassage { get; set; }
    }
}