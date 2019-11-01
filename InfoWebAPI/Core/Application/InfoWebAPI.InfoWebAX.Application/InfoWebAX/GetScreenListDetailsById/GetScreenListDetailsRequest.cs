using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetScreenListDetails", HttpType.Get)]
    public class GetScreenListDetailsRequest : IRequest<GetScreenListDetailsResponse>
    {
        public int AccountId { get; set; }
        public int ScreenListId { get; set; }
    }
}