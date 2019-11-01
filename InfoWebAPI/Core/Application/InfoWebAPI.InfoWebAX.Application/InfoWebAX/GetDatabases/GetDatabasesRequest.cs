using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetDatabases", HttpType.Get)]
    public class GetDatabasesRequest : IRequest<GetDatabasesResponse>
    {
        public int AccountId { get; set; }
    }
}