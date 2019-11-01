using InfoWebAPI.InfoWebAX.Application.InfoService.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetCountriesByListCommand : IRequestHandler<GetCountriesByListRequest, GetCountriesByListResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public GetCountriesByListCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<GetCountriesByListResponse> Handle(GetCountriesByListRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            List<Country> response = new List<Country>();
            try
            {
                response = await _infoServiceWrapper.GetCountries1(request.ListName);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new GetCountriesByListResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                Countries = response
            });
        }
    }
}