using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetStatusByContact", HttpType.Get)]
    public class GetStatusByContactRequest : IRequest<GetStatusByContactResponse>
    {
        public int AccountId { get; set; }
        public string Area { get; set; }
        public int ContactKey { get; set; }
    }
}