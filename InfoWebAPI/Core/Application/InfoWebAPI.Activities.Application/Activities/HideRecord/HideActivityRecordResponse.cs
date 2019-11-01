using InfoWebAPI.Domain.ValueObjects;

namespace InfoWebAPI.Activities.Application
{
    public class HideActivityRecordResponse : ResponseEntity
    {
        public int HideActivityRecordResult { get; set; }
    }
}