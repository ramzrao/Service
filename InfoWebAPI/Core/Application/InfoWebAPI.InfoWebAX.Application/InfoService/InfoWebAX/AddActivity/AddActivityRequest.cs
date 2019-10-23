using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class AddActivityRequest : IRequest<AddActivityResponse>
    {
        public int AccountId { get; set; }
        public int contactKey { get; set; }
        public int gateKey { get; set; }
        public int activityType { get; set; }
        public string computerName { get; set; }
        public int gatePassage { get; set; }
    }
}