﻿using InfoWebAPI.Domain.ValueObjects;
using InfoWebAPI.InfoWebAX.Application.InfoService.Models;
using System.Collections.Generic;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetTextAnswersResponse : ResponseEntity
    {
        public List<TextAnswer> TextAnswers { get; set; }
    }
}