using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Activities.Application
{
    public class AddDefaultActivityCommand : IRequestHandler<AddDefaultActivityRequest, AddDefaultActivityResponse>
    {
        private readonly IMediator _mediator;
        private readonly IActivitiesWrapper _infoServiceWrapper;

        public AddDefaultActivityCommand(IMediator mediator, IActivitiesWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<AddDefaultActivityResponse> Handle(AddDefaultActivityRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            try
            {
                await _infoServiceWrapper.AddDefaultActivity(request.AccountId, request.ShowKey, request.ContactKey, request.ActivityType);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new AddDefaultActivityResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage
            });
        }
    }
}