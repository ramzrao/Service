using InfoWebAPI.Application.InfoService.Models;
using InfoWebAPI.Domain.ValueObjects;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetCoreDetailsByOtherBarcodeResponse : ResponseEntity
    {
        public CoreDetail CoreDetail { get; set; }
    }
}