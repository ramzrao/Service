using InfoWebAPI.Application.InfoService.Models;
using InfoWebAPI.Domain.ValueObjects;
using System.Collections.Generic;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetBarcodesResponse : ResponseEntity
    {
        public List<Barcode> Barcodes { get; set; }
    }
}