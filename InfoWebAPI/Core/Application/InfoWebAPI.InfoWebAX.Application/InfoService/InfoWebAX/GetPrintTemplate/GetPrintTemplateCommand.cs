using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetPrintTemplateCommand : IRequestHandler<GetPrintTemplateRequest, GetPrintTemplateResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public GetPrintTemplateCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<GetPrintTemplateResponse> Handle(GetPrintTemplateRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            try
            {
                var response = await _infoServiceWrapper.GetPrintTemplate(request.AccountId, request.TemplateId);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new GetPrintTemplateResponse
            {
                Success = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage
            });
        }
    }
}