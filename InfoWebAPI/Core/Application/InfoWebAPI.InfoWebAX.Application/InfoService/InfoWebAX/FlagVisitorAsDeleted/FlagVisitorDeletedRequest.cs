using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class FlagVisitorDeletedRequest : IRequest<FlagVisitorDeletedResponse>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
    }
}