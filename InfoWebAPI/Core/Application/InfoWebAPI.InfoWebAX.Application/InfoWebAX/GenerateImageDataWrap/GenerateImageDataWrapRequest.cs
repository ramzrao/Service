using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GenerateImageDataWrap", HttpType.Get)]
    public class GenerateImageDataWrapRequest : IRequest<GenerateImageDataWrapResponse>
    {
        public int AccountId { get; set; }
        public int TemplateId { get; set; }
        public string CardNumber { get; set; }
        public string ComputerName { get; set; }
    }
}