using InfoWebAX;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class FlagVisitorDeletedCommand : IRequestHandler<FlagVisitorDeletedRequest, FlagVisitorDeletedResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public FlagVisitorDeletedCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<FlagVisitorDeletedResponse> Handle(FlagVisitorDeletedRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            FlagVisitorAsDeletedResponse response = null;
            try
            {
                response = await _infoServiceWrapper.FlagVisitorAsDeleted(request.AccountId, request.ContactKey);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new FlagVisitorDeletedResponse
            {
                Success = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                FlagVisitorAsDeletedResult = response?.FlagVisitorAsDeletedResult ?? false
            });
        }
    }
}