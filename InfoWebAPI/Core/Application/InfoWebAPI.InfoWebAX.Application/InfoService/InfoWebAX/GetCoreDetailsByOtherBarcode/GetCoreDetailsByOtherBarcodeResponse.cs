using InfoWebAPI.Application.InfoService.Models;
using InfoWebAPI.Domain.ValueObjects;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetCoreDetailsByOtherBarcodeResponse : ResponseEntity
    {
        public CoreDetail CoreDetail { get; set; }
    }
}