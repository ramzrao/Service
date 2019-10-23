using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetLocalitiesBySuburbRequest : IRequest<GetLocalitiesBySuburbResponse>
    {
        public int AccountId { get; set; }
        public string Country { get; set; }
        public string Suburb { get; set; }
    }
}