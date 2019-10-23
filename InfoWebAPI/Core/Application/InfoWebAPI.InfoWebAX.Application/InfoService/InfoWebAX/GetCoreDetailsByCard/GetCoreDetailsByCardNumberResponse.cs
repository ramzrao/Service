using InfoWebAPI.Application.InfoService.Models;
using InfoWebAPI.Domain.ValueObjects;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetCoreDetailsByCardNumberResponse : ResponseEntity
    {
        public CoreDetail CoreDetail { get; set; }
    }
}