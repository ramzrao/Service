using InfoWebAPI.InfoWebAX.Application.InfoService.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetSessionByKeyCommand : IRequestHandler<GetSessionByKeyRequest, GetSessionByKeyResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public GetSessionByKeyCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<GetSessionByKeyResponse> Handle(GetSessionByKeyRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            Session response = null;
            try
            {
                response = await _infoServiceWrapper.GetSessionByKey(request.AccountId, request.SessionKey);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new GetSessionByKeyResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                Session = response
            });
        }
    }
}