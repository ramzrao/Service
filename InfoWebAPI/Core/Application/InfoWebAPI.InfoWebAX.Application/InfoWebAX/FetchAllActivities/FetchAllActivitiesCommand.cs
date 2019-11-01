using InfoWebAPI.InfoWebAX.Application.InfoService.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class FetchAllActivitiesCommand : IRequestHandler<FetchAllActivitiesRequest, FetchAllActivitiesResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public FetchAllActivitiesCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<FetchAllActivitiesResponse> Handle(FetchAllActivitiesRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            var response = new List<Activity>();
            try
            {
                response = await _infoServiceWrapper.FetchAllActivities(request.AccountId, request.ContactKey);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new FetchAllActivitiesResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                Activities = response
            });
        }
    }
}