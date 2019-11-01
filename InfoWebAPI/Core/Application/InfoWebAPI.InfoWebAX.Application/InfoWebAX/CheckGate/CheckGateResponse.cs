using InfoWebAPI.Domain.ValueObjects;
using InfoWebAPI.InfoWebAX.Application.InfoService.Models;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class CheckGateResponse : ResponseEntity
    {
        public Gate Gate { get; set; }
    }
}