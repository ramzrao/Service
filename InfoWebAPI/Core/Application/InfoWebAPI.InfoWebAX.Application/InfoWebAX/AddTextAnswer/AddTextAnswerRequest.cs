using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "AddTextAnswer", HttpType.Post)]
    public class AddTextAnswerRequest : IRequest<AddTextAnswerResponse>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
        public string Code { get; set; }
        public string TextAnswer { get; set; }
    }
}