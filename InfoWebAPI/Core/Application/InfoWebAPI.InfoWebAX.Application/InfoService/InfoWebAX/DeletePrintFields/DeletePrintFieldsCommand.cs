using InfoWebAX;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class DeletePrintFieldCommand : IRequestHandler<DeletePrintFieldRequest, DeletePrintFieldResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public DeletePrintFieldCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<DeletePrintFieldResponse> Handle(DeletePrintFieldRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            DeletePrintFieldsResponse response = null;
            try
            {
                response = await _infoServiceWrapper.DeletePrintFields(request.AccountId, request.TemplateId);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new DeletePrintFieldResponse
            {
                Success = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                DeletePrintFieldsResult = response?.DeletePrintFieldsResult ?? false
            });
        }
    }
}