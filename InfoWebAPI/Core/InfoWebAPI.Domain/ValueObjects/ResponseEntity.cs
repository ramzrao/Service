namespace InfoWebAPI.Domain.ValueObjects
{
    public class ResponseEntity
    {
        public bool IsServiceCallSuccess { get; set; }
        public string ErrorMessage { get; set; }
    }
}