using InfoWebAPI.Domain.ValueObjects;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class InsertSessionResponse : ResponseEntity
    {
        public int InsertSessionResult { get; set; }
    }
}