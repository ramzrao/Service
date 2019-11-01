using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetBarcodesWithoutFCN", HttpType.Get)]
    public class GetBarcodesWithoutFCNRequest : IRequest<GetBarcodesWithoutFCNResponse>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
    }
}