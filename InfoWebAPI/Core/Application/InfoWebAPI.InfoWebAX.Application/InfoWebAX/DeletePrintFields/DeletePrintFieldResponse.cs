using InfoWebAPI.Common.Attributes;
using InfoWebAPI.Domain.ValueObjects;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "DeletePrintField", HttpType.Delete)]
    public class DeletePrintFieldResponse : ResponseEntity
    {
        public bool DeletePrintFieldsResult { get; set; }
    }
}