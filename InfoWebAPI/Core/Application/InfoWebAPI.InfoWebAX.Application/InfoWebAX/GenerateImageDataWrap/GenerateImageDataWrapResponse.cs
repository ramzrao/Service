using InfoWebAPI.Application.InfoService.Models;
using InfoWebAPI.Domain.ValueObjects;
using System.Collections.Generic;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GenerateImageDataWrapResponse : ResponseEntity
    {
        public List<PrintTemplateData> PrintTemplateData { get; set; }
    }
}