using InfoWebAPI.Application.InfoService.Models;
using InfoWebAPI.Domain.ValueObjects;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetCoreDetailsByCardNumberResponse : ResponseEntity
    {
        public CoreDetail CoreDetail { get; set; }
    }
}