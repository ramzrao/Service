using InfoWebAPI.InfoWebAX.Application.InfoService.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class FetchQuestionsCommand : IRequestHandler<FetchQuestionsRequest, FetchQuestionsResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public FetchQuestionsCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<FetchQuestionsResponse> Handle(FetchQuestionsRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            var response = new List<Question>();
            try
            {
                response = await _infoServiceWrapper.FetchQuestions(request.AccountId);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new FetchQuestionsResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                Questions = response
            });
        }
    }
}