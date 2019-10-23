using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetStatesRequest : IRequest<GetStatesResponse>
    {
        public string ListName { get; set; }
    }
}