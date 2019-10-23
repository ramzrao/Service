using InfoWebAPI.Application.InfoService.Models;
using InfoWebAPI.Domain.ValueObjects;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetShowSettingsResponse : ResponseEntity
    {
        public ShowSettings ShowSettings { get; set; }
    }
}