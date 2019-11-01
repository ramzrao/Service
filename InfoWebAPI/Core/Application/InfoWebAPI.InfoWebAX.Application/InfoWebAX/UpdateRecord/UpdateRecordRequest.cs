using InfoWebAPI.Common.Attributes;
using MediatR;

namespace InfoWebAPI.InfoWebAX.Application
{
    [ApiAttribute("InfoWebAX", "UpdateRecord", HttpType.Post)]
    public class UpdateRecordRequest : IRequest<UpdateRecordResponse>
    {
        public int AccountId { get; set; }
        public string Parameters { get; set; }
    }
}