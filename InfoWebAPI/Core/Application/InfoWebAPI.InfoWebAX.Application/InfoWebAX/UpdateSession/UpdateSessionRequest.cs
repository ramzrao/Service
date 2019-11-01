using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "UpdateSession", HttpType.Post)]
    public class UpdateSessionRequest : IRequest<UpdateSessionResponse>
    {
        public int AccountId { get; set; }
        public int ShowKey { get; set; }
        public string SessionName { get; set; }
        public string SessionCode { get; set; }
        public string SessionDate { get; set; }
        public string SessionStartTime { get; set; }
        public string SessionEndTime { get; set; }
        public double Score { get; set; }
        public bool IsDuplicateScoreAllowed { get; set; }
        public int ExitFor { get; set; }
        public string AttendingAnswerCode { get; set; }
        public string AttendedAnswerCode { get; set; }
        public string Room { get; set; }
        public int SessionKey { get; set; }
    }
}