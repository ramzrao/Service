using InfoWebAPI.Domain.ValueObjects;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetBatchCountResponse : ResponseEntity
    {
        public int GetBatchCountResult { get; set; }
    }
}