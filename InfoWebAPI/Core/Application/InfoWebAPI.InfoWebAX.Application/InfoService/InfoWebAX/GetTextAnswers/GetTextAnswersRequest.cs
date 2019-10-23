using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetTextAnswersRequest : IRequest<GetTextAnswersResponse>
    {
        public int AccountId { get; set; }
        public string CardNumber { get; set; }
    }
}