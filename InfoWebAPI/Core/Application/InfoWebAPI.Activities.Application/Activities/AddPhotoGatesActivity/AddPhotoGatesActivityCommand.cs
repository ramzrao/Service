using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Activities.Application
{
    public class AddPhotoGatesActivityCommand : IRequestHandler<AddPhotoGatesActivityRequest, AddPhotoGatesActivityResponse>
    {
        private readonly IMediator _mediator;
        private readonly IActivitiesWrapper _infoServiceWrapper;

        public AddPhotoGatesActivityCommand(IMediator mediator, IActivitiesWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<AddPhotoGatesActivityResponse> Handle(AddPhotoGatesActivityRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            try
            {
                await _infoServiceWrapper.AddPhotoGatesActivity(request.AccountId, request.ContactKey, request.GateKey, request.IsPhotoGate, request.ComputerName, request.GatePassage);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new AddPhotoGatesActivityResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage
            });
        }
    }
}