using InfoWebAPI.Domain.ValueObjects;
using InfoWebAPI.InfoWebAX.Application.InfoService.Models;
using System.Collections.Generic;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetScreenListDetailsResponse : ResponseEntity
    {
        public List<ScreenListDetail> ScreenListDetails { get; set; }
    }
}