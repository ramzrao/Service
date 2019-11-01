using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class UpdatePrintTemplateCommand : IRequestHandler<UpdatePrintTemplateRequest, UpdatePrintTemplateResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public UpdatePrintTemplateCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<UpdatePrintTemplateResponse> Handle(UpdatePrintTemplateRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            var response = 0;
            try
            {
                response = await _infoServiceWrapper.UpdatePrintTemplate(request.AccountId, request.Name, request.Description, request.IsDefault, request.LabelLength, request.PrinterType,
                    request.BadgeStock, request.MarginLeft, request.MarginRight, request.MarginTop, request.MarginBottom, request.BadgeWidth, request.BadgeHeight, request.MeasurementUnit,
                    request.PageOrientation, request.DefaultPrinter, request.FontName, request.TemplateId);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new UpdatePrintTemplateResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                UpdatePrintTemplateResult = response
            });
        }
    }
}