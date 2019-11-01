using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "SavePhoto", HttpType.Post)]
    public class SavePhotoRequest : IRequest<SavePhotoResponse>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
        public byte[] binaryData { get; set; }
    }
}