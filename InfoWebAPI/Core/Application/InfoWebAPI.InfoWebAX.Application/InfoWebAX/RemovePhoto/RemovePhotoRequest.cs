using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "RemovePhoto", HttpType.Delete)]
    public class RemovePhotoRequest : IRequest<RemovePhotoResponse>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
        public string ComputerName { get; set; }
    }
}