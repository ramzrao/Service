﻿using InfoWebAPI.Domain.ValueObjects;
using InfoWebAPI.InfoWebAX.Application.InfoService.Models;
using System.Collections.Generic;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetCountriesByListResponse : ResponseEntity
    {
        public List<Country> Countries { get; set; }
    }
}