using InfoWebAPI.Domain.ValueObjects;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetNextBatchNumberResponse : ResponseEntity
    {
        public int GetNextBatchNumberResult { get; set; }
    }
}