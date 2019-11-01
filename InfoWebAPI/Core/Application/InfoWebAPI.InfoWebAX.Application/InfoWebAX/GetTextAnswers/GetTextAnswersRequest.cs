using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "GetTextAnswers", HttpType.Get)]
    public class GetTextAnswersRequest : IRequest<GetTextAnswersResponse>
    {
        public int AccountId { get; set; }
        public string CardNumber { get; set; }
    }
}