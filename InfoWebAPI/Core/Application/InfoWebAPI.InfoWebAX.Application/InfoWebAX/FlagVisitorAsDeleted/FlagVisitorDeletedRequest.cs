using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "FlagVisitorDeleted", HttpType.Post)]
    public class FlagVisitorDeletedRequest : IRequest<FlagVisitorDeletedResponse>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
    }
}