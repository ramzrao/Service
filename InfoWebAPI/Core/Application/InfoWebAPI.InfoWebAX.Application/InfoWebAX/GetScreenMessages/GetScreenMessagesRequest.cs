using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetScreenMessages", HttpType.Get)]
    public class GetScreenMessagesRequest : IRequest<GetScreenMessagesResponse>
    {
        public int AccountId { get; set; }
    }
}