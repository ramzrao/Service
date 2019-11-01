using InfoWebAPI.Domain.ValueObjects;
using InfoWebAPI.InfoWebAX.Application.InfoService.Models;
using System.Collections.Generic;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetAllSessionsResponse : ResponseEntity
    {
        public List<Session> Sessions { get; set; }
    }
}