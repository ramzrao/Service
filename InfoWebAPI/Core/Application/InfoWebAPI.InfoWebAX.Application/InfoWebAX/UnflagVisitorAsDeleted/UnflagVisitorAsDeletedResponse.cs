using InfoWebAPI.Domain.ValueObjects;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class UnflagVisitorAsDeletedResponse : ResponseEntity
    {
        public bool UnflagVisitorAsDeletedResult { get; set; }
    }
}