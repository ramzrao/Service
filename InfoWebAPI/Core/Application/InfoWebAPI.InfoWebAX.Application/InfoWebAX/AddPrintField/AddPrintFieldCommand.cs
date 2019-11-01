using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class AddPrintFieldCommand : IRequestHandler<AddPrintFieldRequest, AddPrintFieldResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public AddPrintFieldCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<AddPrintFieldResponse> Handle(AddPrintFieldRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            var response = false;
            try
            {
                response = await _infoServiceWrapper.AddPrintField(request.AccountId, request.TemplateId, request.FieldId, request.FieldType,
                    request.FieldName, request.Top, request.Left, request.Width, request.CharHeight, request.CharWidth, request.Justification,
                    request.FontFamily, request.FontSize, request.Style, request.TextString, request.MaxLength, request.FieldCasing, request.IsBarcode,
                    request.MaxLines, request.Rotation);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new AddPrintFieldResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                AddPrintFieldResult = response
            });
        }
    }
}