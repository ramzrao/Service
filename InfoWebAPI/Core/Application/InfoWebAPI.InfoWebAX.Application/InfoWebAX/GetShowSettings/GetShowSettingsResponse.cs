using InfoWebAPI.Application.InfoService.Models;
using InfoWebAPI.Domain.ValueObjects;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetShowSettingsResponse : ResponseEntity
    {
        public ShowSettings ShowSettings { get; set; }
    }
}