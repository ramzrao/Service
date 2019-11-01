﻿using InfoWebAPI.Application.InfoService.Models;
using InfoWebAPI.Domain.ValueObjects;
using System.Collections.Generic;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetAllPrintTemplatesResponse : ResponseEntity
    {
        public IEnumerable<PrintTemplate> PrintTemplateList { get; set; }
    }
}