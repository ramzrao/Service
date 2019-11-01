using InfoWebAPI.InfoWebAX.Application.InfoService.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GetTextAnswersCommand : IRequestHandler<GetTextAnswersRequest, GetTextAnswersResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public GetTextAnswersCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<GetTextAnswersResponse> Handle(GetTextAnswersRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            var response = new List<TextAnswer>();
            try
            {
                response = await _infoServiceWrapper.GetTextAnswers(request.AccountId, request.CardNumber);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new GetTextAnswersResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                TextAnswers = response
            });
        }
    }
}