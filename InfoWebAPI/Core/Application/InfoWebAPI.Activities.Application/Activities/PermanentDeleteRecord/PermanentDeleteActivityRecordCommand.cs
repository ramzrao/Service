using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Activities.Application
{
    public class PermanentDeleteActivityRecordCommand : IRequestHandler<PermanentDeleteActivityRecordRequest, PermanentDeleteActivityRecordResponse>
    {
        private readonly IMediator _mediator;
        private readonly IActivitiesWrapper _infoServiceWrapper;

        public PermanentDeleteActivityRecordCommand(IMediator mediator, IActivitiesWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<PermanentDeleteActivityRecordResponse> Handle(PermanentDeleteActivityRecordRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            var response = 0;
            try
            {
                response = await _infoServiceWrapper.PermanentDeleteRecord(request.AccountId, request.ContactKey);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new PermanentDeleteActivityRecordResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                PermanentDeleteRecordResult = response
            });
        }
    }
}