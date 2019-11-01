using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Activities.Application
{
    public class RestoreActivityRecordCommand : IRequestHandler<RestoreActivityRecordRequest, RestoreActivityRecordResponse>
    {
        private readonly IMediator _mediator;
        private readonly IActivitiesWrapper _infoServiceWrapper;

        public RestoreActivityRecordCommand(IMediator mediator, IActivitiesWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<RestoreActivityRecordResponse> Handle(RestoreActivityRecordRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            var response = 0;
            try
            {
                response = await _infoServiceWrapper.RestoreRecord(request.AccountId, request.ContactKey);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new RestoreActivityRecordResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                RestoreActivityResult = response
            });
        }
    }
}