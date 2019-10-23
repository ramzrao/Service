using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class AddTextAnswerRequest : IRequest<AddTextAnswerResponse>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
        public string Code { get; set; }
        public string TextAnswer { get; set; }
    }
}