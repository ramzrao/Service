using InfoWebAPI.Application.InfoService.Models;
using InfoWebAPI.Domain.ValueObjects;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetCoreDetailsResponse : ResponseEntity
    {
        public CoreDetail CoreDetail { get; set; }
    }
}