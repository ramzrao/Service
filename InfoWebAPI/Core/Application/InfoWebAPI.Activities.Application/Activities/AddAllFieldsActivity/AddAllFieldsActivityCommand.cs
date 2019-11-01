using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Activities.Application
{
    public class AddAllFieldsActivityCommand : IRequestHandler<AddAllFieldsActivityRequest, AddAllFieldsActivityResponse>
    {
        private readonly IMediator _mediator;
        private readonly IActivitiesWrapper _infoServiceWrapper;

        public AddAllFieldsActivityCommand(IMediator mediator, IActivitiesWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<AddAllFieldsActivityResponse> Handle(AddAllFieldsActivityRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            try
            {
                await _infoServiceWrapper.AddAllFieldsActivity(request.AccountId, request.ShowKey, request.ContactKey, request.ActivityDate, request.GateKey,
                    request.ActivityType, request.ActivityUsername, request.ImportBatch, request.SyncStatus);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new AddAllFieldsActivityResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage
            });
        }
    }
}