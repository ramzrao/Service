using InfoWebAPI.Domain.ValueObjects;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class FlagVisitorDeletedResponse : ResponseEntity
    {
        public bool FlagVisitorAsDeletedResult { get; set; }
    }
}