using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class CheckGateCommand : IRequestHandler<CheckGateRequest, CheckGateResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public CheckGateCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<CheckGateResponse> Handle(CheckGateRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            try
            {
                var response = await _infoServiceWrapper.CheckGate(request.AccountId, request.GateNumber);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new CheckGateResponse
            {
                Success = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage
            });
        }
    }
}