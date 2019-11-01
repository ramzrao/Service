using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class UpdateResponsesCommand : IRequestHandler<UpdateResponsesRequest, UpdateResponsesResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public UpdateResponsesCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<UpdateResponsesResponse> Handle(UpdateResponsesRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            var response = false;
            try
            {
                response = await _infoServiceWrapper.UpdateResponses(request.AccountId, request.ContactKey, request.ResponseCodes);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new UpdateResponsesResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                UpdateResponsesResult = response
            });
        }
    }
}