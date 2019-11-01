using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GenerateImageData3", HttpType.Get)]
    public class GenerateImageData3Request : IRequest<GenerateImageData3Response>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
        public string ComputerName { get; set; }
    }
}