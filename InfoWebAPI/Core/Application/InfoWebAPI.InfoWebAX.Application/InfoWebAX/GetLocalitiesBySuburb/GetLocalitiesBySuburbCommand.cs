using InfoWebAPI.InfoWebAX.Application.InfoService.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetLocalitiesBySuburbCommand : IRequestHandler<GetLocalitiesBySuburbRequest, GetLocalitiesBySuburbResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public GetLocalitiesBySuburbCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<GetLocalitiesBySuburbResponse> Handle(GetLocalitiesBySuburbRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            List<Locality> response = new List<Locality>();
            try
            {
                response = await _infoServiceWrapper.GetLocalitiesBySuburb(request.AccountId, request.Country, request.Suburb);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new GetLocalitiesBySuburbResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                Localities = response
            });
        }
    }
}