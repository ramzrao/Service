using InfoWebAPI.InfoWebAX.Application.InfoService.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetAllSessionsCommand : IRequestHandler<GetAllSessionsRequest, GetAllSessionsResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public GetAllSessionsCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<GetAllSessionsResponse> Handle(GetAllSessionsRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            var response = new List<Session>();
            try
            {
                response = await _infoServiceWrapper.GetAllSessions(request.AccountId);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new GetAllSessionsResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                Sessions = response
            });
        }
    }
}