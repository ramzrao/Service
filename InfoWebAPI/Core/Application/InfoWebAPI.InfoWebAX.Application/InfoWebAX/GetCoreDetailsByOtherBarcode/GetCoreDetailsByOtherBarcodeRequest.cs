using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetCoreDetailsByOtherBarcode", HttpType.Get)]
    public class GetCoreDetailsByOtherBarcodeRequest : IRequest<GetCoreDetailsByOtherBarcodeResponse>
    {
        public int AccountId { get; set; }
        public string CardNumber { get; set; }
    }
}