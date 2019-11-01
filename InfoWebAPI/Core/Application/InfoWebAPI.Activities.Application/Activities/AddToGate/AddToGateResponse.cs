using InfoWebAPI.Domain.ValueObjects;

namespace InfoWebAPI.Activities.Application
{
    public class AddToGateResponse : ResponseEntity
    {
        public int AddToGateResult { get; set; }
    }
}