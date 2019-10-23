using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class FetchFieldSetupRequest : IRequest<FetchFieldSetupResponse>
    {
        public int AccountId { get; set; }
    }
}