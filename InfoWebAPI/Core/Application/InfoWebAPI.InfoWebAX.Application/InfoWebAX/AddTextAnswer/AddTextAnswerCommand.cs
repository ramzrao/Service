using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class AddTextAnswerCommand : IRequestHandler<AddTextAnswerRequest, AddTextAnswerResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public AddTextAnswerCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<AddTextAnswerResponse> Handle(AddTextAnswerRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            var response = false;
            try
            {
                response = await _infoServiceWrapper.AddTextAnswer(request.AccountId, request.ContactKey, request.Code,
                                                                    request.TextAnswer);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new AddTextAnswerResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                AddTextAnswerResult = response
            });
        }
    }
}