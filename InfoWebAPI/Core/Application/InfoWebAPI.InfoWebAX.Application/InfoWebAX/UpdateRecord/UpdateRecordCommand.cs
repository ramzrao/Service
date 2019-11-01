using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class UpdateRecordCommand : IRequestHandler<UpdateRecordRequest, UpdateRecordResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public UpdateRecordCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<UpdateRecordResponse> Handle(UpdateRecordRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            var response = 0;
            try
            {
                response = await _infoServiceWrapper.UpdateRecord(request.AccountId, request.Parameters);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new UpdateRecordResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                UpdateRecordResult = response
            });
        }
    }
}