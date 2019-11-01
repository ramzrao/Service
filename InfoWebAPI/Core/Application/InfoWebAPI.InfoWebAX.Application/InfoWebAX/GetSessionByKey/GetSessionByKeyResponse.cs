using InfoWebAPI.Domain.ValueObjects;
using InfoWebAPI.InfoWebAX.Application.InfoService.Models;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetSessionByKeyResponse : ResponseEntity
    {
        public Session Session { get; set; }
    }
}