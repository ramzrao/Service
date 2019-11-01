using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "UndoLastPhotoGateScan", HttpType.Post)]
    public class UndoLastPhotoGateScanRequest : IRequest<UndoLastPhotoGateScanResponse>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
        public string GateName { get; set; }
    }
}