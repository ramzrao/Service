using InfoWebAPI.Domain.ValueObjects;

namespace InfoWebAPI.Activities.Application
{
    public class RestoreActivityRecordResponse : ResponseEntity
    {
        public int RestoreActivityResult { get; set; }
    }
}