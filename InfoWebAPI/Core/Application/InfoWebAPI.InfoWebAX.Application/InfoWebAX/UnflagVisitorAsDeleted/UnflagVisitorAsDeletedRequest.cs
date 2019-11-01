using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "UnflagVisitorAsDeleted", HttpType.Post)]
    public class UnflagVisitorAsDeletedRequest : IRequest<UnflagVisitorAsDeletedResponse>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
    }
}