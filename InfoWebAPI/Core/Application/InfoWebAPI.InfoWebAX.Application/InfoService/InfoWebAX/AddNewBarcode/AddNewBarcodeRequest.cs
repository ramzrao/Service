using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class AddNewBarcodeRequest : IRequest<AddNewBarcodeResponse>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
        public string BarcodeNumber { get; set; }
    }
}