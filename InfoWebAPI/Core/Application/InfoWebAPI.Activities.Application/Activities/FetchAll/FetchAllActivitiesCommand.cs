using InfoWebAPI.Activities.Application.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Activities.Application
{
    public class FetchAllActivitiesCommand : IRequestHandler<FetchAllActivitiesRequest, FetchAllActivitiesResponse>
    {
        private readonly IMediator _mediator;
        private readonly IActivitiesWrapper _infoServiceWrapper;

        public FetchAllActivitiesCommand(IMediator mediator, IActivitiesWrapper infoServiceWrapper)
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
                response = await _infoServiceWrapper.FetchAll(request.AccountId, request.ContactKey);
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