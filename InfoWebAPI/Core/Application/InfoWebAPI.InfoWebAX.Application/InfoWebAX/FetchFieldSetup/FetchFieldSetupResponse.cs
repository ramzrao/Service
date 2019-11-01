using InfoWebAPI.Domain.ValueObjects;
using InfoWebAPI.InfoWebAX.Application.InfoService.Models;
using System.Collections.Generic;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class FetchFieldSetupResponse : ResponseEntity
    {
        public List<Field> Fields { get; set; }
    }
}