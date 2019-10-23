using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class DeletePrintTemplateCommand : IRequestHandler<DeletePrintTemplateRequest, DeletePrintTemplateResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public DeletePrintTemplateCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<DeletePrintTemplateResponse> Handle(DeletePrintTemplateRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            bool response = false;
            try
            {
                response = await _infoServiceWrapper.DeletePrintTemplate(request.AccountId, request.TemplateId);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new DeletePrintTemplateResponse
            {
                Success = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                DeletePrintTemplateResult = response
            });
        }
    }
}