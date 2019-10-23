using InfoWebAPI.Application.InfoService.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetCoreDetailsByOtherBarcodeCommand : IRequestHandler<GetCoreDetailsByOtherBarcodeRequest, GetCoreDetailsByOtherBarcodeResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public GetCoreDetailsByOtherBarcodeCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<GetCoreDetailsByOtherBarcodeResponse> Handle(GetCoreDetailsByOtherBarcodeRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            CoreDetail response = null;
            try
            {
                response = await _infoServiceWrapper.GetCoreDetailsByOtherBarcode(request.AccountId, request.CardNumber);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new GetCoreDetailsByOtherBarcodeResponse
            {
                Success = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                CoreDetail = response
            });
        }
    }
}