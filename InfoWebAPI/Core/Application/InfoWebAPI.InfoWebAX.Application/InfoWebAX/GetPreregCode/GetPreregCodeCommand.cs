using InfoWebAPI.InfoWebAX.Application.InfoService.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetPreregCodeCommand : IRequestHandler<GetPreregCodeRequest, GetPreregCodeResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public GetPreregCodeCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<GetPreregCodeResponse> Handle(GetPreregCodeRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            List<PreregCode> response = new List<PreregCode>();
            try
            {
                response = await _infoServiceWrapper.GetPreregCode(request.AccountId);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new GetPreregCodeResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                PreregCodes = response
            });
        }
    }
}