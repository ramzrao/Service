using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class UndoLastPhotoGateScanCommand : IRequestHandler<UndoLastPhotoGateScanRequest, UndoLastPhotoGateScanResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public UndoLastPhotoGateScanCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<UndoLastPhotoGateScanResponse> Handle(UndoLastPhotoGateScanRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            var response = 0;
            try
            {
                response = await _infoServiceWrapper.UndoLastPhotoGateScan(request.AccountId, request.ContactKey, request.GateName);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new UndoLastPhotoGateScanResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                UndoLastPhotoGateScanResult = response
            });
        }
    }
}