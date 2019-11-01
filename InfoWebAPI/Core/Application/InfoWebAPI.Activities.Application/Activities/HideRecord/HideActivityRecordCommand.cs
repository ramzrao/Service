using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Activities.Application
{
    public class HideActivityRecordCommand : IRequestHandler<HideActivityRecordRequest, HideActivityRecordResponse>
    {
        private readonly IMediator _mediator;
        private readonly IActivitiesWrapper _infoServiceWrapper;

        public HideActivityRecordCommand(IMediator mediator, IActivitiesWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<HideActivityRecordResponse> Handle(HideActivityRecordRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            int response = 0;
            try
            {
                response = await _infoServiceWrapper.HideRecord(request.AccountId, request.ContactKey);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new HideActivityRecordResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                HideActivityRecordResult = response
            });
        }
    }
}