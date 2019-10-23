using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetCountriesByListRequest : IRequest<GetCountriesByListResponse>
    {
        public string ListName { get; set; }
    }
}