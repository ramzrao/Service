using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GenerateImageData2", HttpType.Get)]
    public class GenerateImageData2Request : IRequest<GenerateImageData2Response>
    {
        public int AccountId { get; set; }
        public int PrintTemplateId { get; set; }
        public string ComputerName { get; set; }
    }
}