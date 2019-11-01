using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "FetchQuestions", HttpType.Get)]
    public class FetchQuestionsRequest : IRequest<FetchQuestionsResponse>
    {
        public int AccountId { get; set; }
    }
}