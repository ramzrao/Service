using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetStatusByContactRequest : IRequest<GetStatusByContactResponse>
    {
        public int AccountId { get; set; }
        public string Area { get; set; }
        public int ContactKey { get; set; }
    }
}