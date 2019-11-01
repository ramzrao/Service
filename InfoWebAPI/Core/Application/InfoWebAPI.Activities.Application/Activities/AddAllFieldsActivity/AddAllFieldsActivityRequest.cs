using InfoWebAPI.Common.Attributes;
using MediatR;
using System;

namespace InfoWebAPI.Activities.Application
{
    [ApiAttribute("Activities", "AddAllFieldsActivity", HttpType.Post)]
    public class AddAllFieldsActivityRequest : IRequest<AddAllFieldsActivityResponse>
    {
        public int AccountId { get; set; }
        public int ShowKey { get; set; }
        public int ContactKey { get; set; }
        public int ActivityType { get; set; }
        public DateTime ActivityDate { get; set; }
        public int GateKey { get; set; }
        public string ActivityUsername { get; set; }
        public int ImportBatch { get; set; }
        public int SyncStatus { get; set; }
    }
}