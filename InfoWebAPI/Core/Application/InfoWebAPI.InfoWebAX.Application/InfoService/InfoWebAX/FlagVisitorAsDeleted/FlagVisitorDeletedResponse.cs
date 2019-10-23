using InfoWebAPI.Domain.ValueObjects;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class FlagVisitorDeletedResponse : ResponseEntity
    {
        public bool FlagVisitorAsDeletedResult { get; set; }
    }
}