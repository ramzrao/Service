using InfoWebAPI.Domain.ValueObjects;

namespace InfoWebAPI.Activities.Application
{
    public class PermanentDeleteActivityRecordResponse : ResponseEntity
    {
        public int PermanentDeleteRecordResult { get; set; }
    }
}