using InfoWebAPI.Domain.ValueObjects;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetBatchCountResponse : ResponseEntity
    {
        public int GetBatchCountResult { get; set; }
    }
}