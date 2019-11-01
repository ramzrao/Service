using InfoWebAPI.Activities.Application.Models;
using InfoWebAPI.Domain.ValueObjects;
using System.Collections.Generic;

namespace InfoWebAPI.Activities.Application
{
    public class FetchByActivityResponse : ResponseEntity
    {
        public List<Activity> Activities { get; set; }
    }
}