using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.Activities.Application
{
    [ApiAttribute("Activities", "DeleteActivity", HttpType.Delete)]
    public class DeleteActivityRequest : IRequest<DeleteActivityResponse>
    {
        public int AccountId { get; set; }
        public int ContactKey { get; set; }
    }
}