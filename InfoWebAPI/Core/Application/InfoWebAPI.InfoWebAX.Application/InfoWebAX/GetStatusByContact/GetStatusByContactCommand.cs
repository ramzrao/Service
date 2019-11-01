using InfoWebAPI.Application.InfoService.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetStatusByContactCommand : IRequestHandler<GetStatusByContactRequest, GetStatusByContactResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public GetStatusByContactCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<GetStatusByContactResponse> Handle(GetStatusByContactRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            List<Status> response = new List<Status>();
            try
            {
                response = await _infoServiceWrapper.GetStatus2(request.AccountId, request.Area, request.ContactKey,
                                                                    null);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new GetStatusByContactResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                Status = response
            });
        }
    }
}