using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "InsertSession", HttpType.Get)]
    public class InsertSessionRequest : IRequest<InsertSessionResponse>
    {
        public int AccountId { get; set; }
        public string SessionCode { get; set; }
        public string SessionName { get; set; }
        public string SessionDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public double Score { get; set; }
        public bool AllowDupYN { get; set; }
        public int ExitFor { get; set; }
        public string AttendingCode { get; set; }
        public string AttendedCode { get; set; }
        public string Room { get; set; }
    }
}