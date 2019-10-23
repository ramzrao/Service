using InfoWebAPI.Domain.ValueObjects;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetNextBatchNumberResponse : ResponseEntity
    {
        public int GetNextBatchNumberResult { get; set; }
    }
}