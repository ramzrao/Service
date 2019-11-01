using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class UnflagVisitorAsDeletedCommand : IRequestHandler<UnflagVisitorAsDeletedRequest, UnflagVisitorAsDeletedResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public UnflagVisitorAsDeletedCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<UnflagVisitorAsDeletedResponse> Handle(UnflagVisitorAsDeletedRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            var response = false;
            try
            {
                response = await _infoServiceWrapper.UnflagVisitorAsDeleted(request.AccountId, request.ContactKey);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new UnflagVisitorAsDeletedResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                UnflagVisitorAsDeletedResult = response
            });
        }
    }
}