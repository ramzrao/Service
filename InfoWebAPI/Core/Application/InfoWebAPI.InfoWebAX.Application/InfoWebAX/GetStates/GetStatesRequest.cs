using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetStates", HttpType.Get)]
    public class GetStatesRequest : IRequest<GetStatesResponse>
    {
        public string ListName { get; set; }
    }
}