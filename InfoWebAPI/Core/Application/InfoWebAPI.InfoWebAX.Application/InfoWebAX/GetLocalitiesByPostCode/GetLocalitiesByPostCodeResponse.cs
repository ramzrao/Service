using InfoWebAPI.Domain.ValueObjects;
using InfoWebAPI.InfoWebAX.Application.InfoService.Models;
using System.Collections.Generic;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetLocalitiesByPostCodeResponse : ResponseEntity
    {
        public List<Locality> Localities { get; set; }
    }
}