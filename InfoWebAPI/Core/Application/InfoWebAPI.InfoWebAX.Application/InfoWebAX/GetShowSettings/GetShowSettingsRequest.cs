using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetShowSettings", HttpType.Get)]
    public class GetShowSettingsRequest : IRequest<GetShowSettingsResponse>
    {
        public int AccountId { get; set; }
    }
}