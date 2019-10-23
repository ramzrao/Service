using MediatR;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class UpdateRecordRequest : IRequest<UpdateRecordResponse>
    {
        public int AccountId { get; set; }
        public string Parameters { get; set; }
    }
}