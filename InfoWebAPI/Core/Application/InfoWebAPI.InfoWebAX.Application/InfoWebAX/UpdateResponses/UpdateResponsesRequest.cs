using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "UpdateResponses", HttpType.Post)]
    public class UpdateResponsesRequest : IRequest<UpdateResponsesResponse>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
        public string ResponseCodes { get; set; }
    }
}