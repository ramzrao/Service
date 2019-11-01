using InfoWebAPI.Application.InfoService.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetShowSettingsCommand : IRequestHandler<GetShowSettingsRequest, GetShowSettingsResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public GetShowSettingsCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<GetShowSettingsResponse> Handle(GetShowSettingsRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            ShowSettings response = null;
            try
            {
                response = await _infoServiceWrapper.GetShowSettings(request.AccountId);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new GetShowSettingsResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                ShowSettings = response
            });
        }
    }
}