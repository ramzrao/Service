using InfoWebAPI.Domain.ValueObjects;
using InfoWebAPI.InfoWebAX.Application.InfoService.Models;
using System.Collections.Generic;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class FetchAllActivitiesResponse : ResponseEntity
    {
        public List<Activity> Activities { get; set; }
    }
}