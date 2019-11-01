using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "AddNewBarcode", HttpType.Post)]
    public class AddNewBarcodeRequest : IRequest<AddNewBarcodeResponse>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
        public string BarcodeNumber { get; set; }
    }
}