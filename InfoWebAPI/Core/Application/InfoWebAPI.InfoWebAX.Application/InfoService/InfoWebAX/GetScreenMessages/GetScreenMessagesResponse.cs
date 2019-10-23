using InfoWebAPI.Application.InfoService.Models;
using InfoWebAPI.Domain.ValueObjects;
using System.Collections.Generic;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetScreenMessagesResponse : ResponseEntity
    {
        public List<ScreenMessage> ScreenMessages { get; set; }
    }
}