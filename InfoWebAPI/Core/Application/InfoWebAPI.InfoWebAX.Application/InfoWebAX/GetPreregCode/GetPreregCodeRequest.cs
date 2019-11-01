using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetPreregCode", HttpType.Get)]
    public class GetPreregCodeRequest : IRequest<GetPreregCodeResponse>
    {
        public int AccountId { get; set; }
    }
}