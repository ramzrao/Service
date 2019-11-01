using InfoWebAPI.InfoWebAX.Application.InfoService.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetLocalitiesByPostCodeCommand : IRequestHandler<GetLocalitiesByPostCodeRequest, GetLocalitiesByPostCodeResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public GetLocalitiesByPostCodeCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<GetLocalitiesByPostCodeResponse> Handle(GetLocalitiesByPostCodeRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            List<Locality> response = new List<Locality>();
            try
            {
                response = await _infoServiceWrapper.GetLocalitiesByPostCode(request.AccountId, request.Country, request.PostCode);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new GetLocalitiesByPostCodeResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                Localities = response
            });
        }
    }
}