using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Activities.Application
{
    public class AddPhotoActivityCommand : IRequestHandler<AddPhotoActivityRequest, AddPhotoActivityResponse>
    {
        private readonly IMediator _mediator;
        private readonly IActivitiesWrapper _infoServiceWrapper;

        public AddPhotoActivityCommand(IMediator mediator, IActivitiesWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<AddPhotoActivityResponse> Handle(AddPhotoActivityRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            try
            {
                await _infoServiceWrapper.AddPhotoActivity(request.AccountId, request.ContactKey, request.ActivityType, request.ShowKey, request.GateKey, request.ComputerName);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new AddPhotoActivityResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage
            });
        }
    }
}