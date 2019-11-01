using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Activities.Application
{
    public class AddToGateCommand : IRequestHandler<AddToGateRequest, AddToGateResponse>
    {
        private readonly IMediator _mediator;
        private readonly IActivitiesWrapper _infoServiceWrapper;

        public AddToGateCommand(IMediator mediator, IActivitiesWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<AddToGateResponse> Handle(AddToGateRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            int response = 0;
            try
            {
                response = await _infoServiceWrapper.AddToGate(request.AccountId, request.ShowKey, request.GateNumber, request.CardNumber);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new AddToGateResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                AddToGateResult = response
            });
        }
    }
}