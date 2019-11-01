using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class AddGatePassage2Command : IRequestHandler<AddGatePassage2Request, AddGatePassage2Response>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public AddGatePassage2Command(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<AddGatePassage2Response> Handle(AddGatePassage2Request request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            try
            {
                await _infoServiceWrapper.AddGatePassage2(request.AccountId, request.ContactKey, request.CardNumber,
                                                                    request.GateNumber, request.ComputerName);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new AddGatePassage2Response
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage
            });
        }
    }
}