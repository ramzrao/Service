using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetBatchCountCommand : IRequestHandler<GetBatchCountRequest, GetBatchCountResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public GetBatchCountCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<GetBatchCountResponse> Handle(GetBatchCountRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            int response = 0;
            try
            {
                response = await _infoServiceWrapper.GetBatchCount(request.AccountId, request.BatchNumber);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new GetBatchCountResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                GetBatchCountResult = response
            });
        }
    }
}