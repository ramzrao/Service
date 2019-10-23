using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetDatabasesRequest : IRequest<GetDatabasesResponse>
    {
        public int AccountId { get; set; }
    }
}