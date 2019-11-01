using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "AddActivity", HttpType.Post)]
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