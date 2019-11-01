using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "AddPhotoGatePassage", HttpType.Post)]
    public class AddPhotoGatePassageRequest : IRequest<AddPhotoGatePassageResponse>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
        public string CardNumber { get; set; }
        public string GateNumber { get; set; }
        public string ComputerName { get; set; }
    }
}