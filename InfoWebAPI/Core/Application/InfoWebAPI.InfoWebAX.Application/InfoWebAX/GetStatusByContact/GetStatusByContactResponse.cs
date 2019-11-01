using InfoWebAPI.Application.InfoService.Models;
using InfoWebAPI.Domain.ValueObjects;
using System.Collections.Generic;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetStatusByContactResponse : ResponseEntity
    {
        public List<Status> Status { get; set; }
    }
}