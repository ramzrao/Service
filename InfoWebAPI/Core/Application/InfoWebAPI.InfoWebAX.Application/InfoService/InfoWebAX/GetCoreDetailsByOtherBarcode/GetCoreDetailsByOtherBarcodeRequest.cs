using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetCoreDetailsByOtherBarcodeRequest : IRequest<GetCoreDetailsByOtherBarcodeResponse>
    {
        public int AccountId { get; set; }
        public string CardNumber { get; set; }
    }
}