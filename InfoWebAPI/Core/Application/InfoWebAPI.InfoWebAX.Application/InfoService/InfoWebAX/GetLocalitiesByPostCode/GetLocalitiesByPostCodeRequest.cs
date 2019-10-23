using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetLocalitiesByPostCodeRequest : IRequest<GetLocalitiesByPostCodeResponse>
    {
        public int AccountId { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }
    }
}