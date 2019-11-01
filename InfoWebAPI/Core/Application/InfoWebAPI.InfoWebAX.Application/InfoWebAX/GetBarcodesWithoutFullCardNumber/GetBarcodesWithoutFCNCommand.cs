using InfoWebAPI.Application.InfoService.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetBarcodesWithoutFCNCommand : IRequestHandler<GetBarcodesWithoutFCNRequest, GetBarcodesWithoutFCNResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public GetBarcodesWithoutFCNCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<GetBarcodesWithoutFCNResponse> Handle(GetBarcodesWithoutFCNRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            List<Barcode> response = new List<Barcode>();
            try
            {
                response = await _infoServiceWrapper.GetBarcodesWithoutFullCardNumber(request.AccountId, request.ContactKey);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new GetBarcodesWithoutFCNResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                Barcodes = response
            });
        }
    }
}