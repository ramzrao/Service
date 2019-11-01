using InfoWebAPI.Application.InfoService.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetScreenMessagesCommand : IRequestHandler<GetScreenMessagesRequest, GetScreenMessagesResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public GetScreenMessagesCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<GetScreenMessagesResponse> Handle(GetScreenMessagesRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            var response = new List<ScreenMessage>();
            try
            {
                response = await _infoServiceWrapper.GetScreenMessages(request.AccountId);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new GetScreenMessagesResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                ScreenMessages = response
            });
        }
    }
}