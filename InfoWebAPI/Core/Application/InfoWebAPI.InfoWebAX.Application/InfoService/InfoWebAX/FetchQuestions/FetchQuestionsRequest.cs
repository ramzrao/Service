using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class FetchQuestionsRequest : IRequest<FetchQuestionsResponse>
    {
        public int AccountId { get; set; }
    }
}