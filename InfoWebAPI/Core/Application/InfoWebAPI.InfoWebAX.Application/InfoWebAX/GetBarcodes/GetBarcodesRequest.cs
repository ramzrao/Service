using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetBarcodes", HttpType.Get)]
    public class GetBarcodesRequest : IRequest<GetBarcodesResponse>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
    }
}