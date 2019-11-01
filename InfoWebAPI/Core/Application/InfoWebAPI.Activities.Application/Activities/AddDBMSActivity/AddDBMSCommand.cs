using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Activities.Application
{
    public class AddDBMSCommand : IRequestHandler<AddDBMSRequest, AddDBMSResponse>
    {
        private readonly IMediator _mediator;
        private readonly IActivitiesWrapper _infoServiceWrapper;

        public AddDBMSCommand(IMediator mediator, IActivitiesWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<AddDBMSResponse> Handle(AddDBMSRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            try
            {
                await _infoServiceWrapper.AddDBMSActivity(request.AccountId, request.ShowKey, request.ContactKey, request.ActivityType, request.ActivityUsername);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new AddDBMSResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage
            });
        }
    }
}