using InfoWebAPI.Domain.ValueObjects;
using InfoWebAPI.InfoWebAX.Application.InfoService.Models;
using System.Collections.Generic;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class FetchQuestionsResponse : ResponseEntity
    {
        public List<Question> Questions { get; set; }
    }
}