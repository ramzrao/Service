using InfoWebAPI.InfoWebAX.Application.InfoService.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class SearchAddressCommand : IRequestHandler<SearchAddressRequest, SearchAddressResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public SearchAddressCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<SearchAddressResponse> Handle(SearchAddressRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            var response = new List<QASAddress>();
            try
            {
                response = await _infoServiceWrapper.SearchAddress(request.SearchText, request.Moniker, request.DisplayTextArray);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new SearchAddressResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                AddressList = response
            });
        }
    }
}