using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetNextBatchNumberCommand : IRequestHandler<GetNextBatchNumberRequest, GetNextBatchNumberResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public GetNextBatchNumberCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<GetNextBatchNumberResponse> Handle(GetNextBatchNumberRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            int response = 0;
            try
            {
                response = await _infoServiceWrapper.GetNextBatchNumber(request.AccountId);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new GetNextBatchNumberResponse
            {
                Success = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                GetNextBatchNumberResult = response
            });
        }
    }
}