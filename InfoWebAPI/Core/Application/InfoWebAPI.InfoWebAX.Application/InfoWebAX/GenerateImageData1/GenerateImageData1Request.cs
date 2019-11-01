using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GenerateImageData1", HttpType.Get)]
    public class GenerateImageData1Request : IRequest<GenerateImageData1Response>
    {
        public int AccountId { get; set; }
        public string ComputerName { get; set; }
    }
}