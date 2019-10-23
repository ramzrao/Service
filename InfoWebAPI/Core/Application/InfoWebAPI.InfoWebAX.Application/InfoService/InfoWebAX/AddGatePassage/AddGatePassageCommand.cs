using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class AddGatePassageCommand : IRequestHandler<AddGatePassageRequest, AddGatePassageResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public AddGatePassageCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<AddGatePassageResponse> Handle(AddGatePassageRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            try
            {
                var response = await _infoServiceWrapper.AddGatePassage(request.AccountId, request.ContactKey, request.GateNumber);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new AddGatePassageResponse
            {
                Success = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage
            });
        }
    }
}