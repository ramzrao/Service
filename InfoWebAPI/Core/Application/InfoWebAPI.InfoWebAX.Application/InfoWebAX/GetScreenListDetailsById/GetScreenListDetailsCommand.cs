using InfoWebAPI.InfoWebAX.Application.InfoService.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetScreenListDetailsCommand : IRequestHandler<GetScreenListDetailsRequest, GetScreenListDetailsResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public GetScreenListDetailsCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<GetScreenListDetailsResponse> Handle(GetScreenListDetailsRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            var response = new List<ScreenListDetail>();
            try
            {
                response = await _infoServiceWrapper.GetScreenListDetailsById(request.AccountId, request.ScreenListId);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new GetScreenListDetailsResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                ScreenListDetails = response
            });
        }
    }
}