using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "FetchFieldSetup", HttpType.Get)]
    public class FetchFieldSetupRequest : IRequest<FetchFieldSetupResponse>
    {
        public int AccountId { get; set; }
    }
}