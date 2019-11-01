using InfoWebAPI.Domain.ValueObjects;
using InfoWebAPI.InfoWebAX.Application.InfoService.Models;
using System.Collections.Generic;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetPreregCodeResponse : ResponseEntity
    {
        public List<PreregCode> PreregCodes { get; set; }
    }
}