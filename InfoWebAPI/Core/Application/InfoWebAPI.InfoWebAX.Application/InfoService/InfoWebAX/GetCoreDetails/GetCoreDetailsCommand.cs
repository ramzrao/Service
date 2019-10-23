using InfoWebAPI.Application.InfoService.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetCoreDetailsCommand : IRequestHandler<GetCoreDetailsRequest, GetCoreDetailsResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public GetCoreDetailsCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<GetCoreDetailsResponse> Handle(GetCoreDetailsRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            CoreDetail response = null;
            try
            {
                response = await _infoServiceWrapper.GetCoreDetails1(request.AccountId, request.ActiveOnly, request.RowLimit,
                                                                    request.QueryParams);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new GetCoreDetailsResponse
            {
                Success = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                CoreDetail = response
            });
        }
    }
}