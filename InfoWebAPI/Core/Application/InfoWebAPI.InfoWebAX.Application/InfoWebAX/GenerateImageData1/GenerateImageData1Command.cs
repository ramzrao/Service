using InfoWebAPI.Application.InfoService.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GenerateImageData1Command : IRequestHandler<GenerateImageData1Request, GenerateImageData1Response>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public GenerateImageData1Command(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<GenerateImageData1Response> Handle(GenerateImageData1Request request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            List<PrintTemplateData> response = new List<PrintTemplateData>();
            try
            {
                response = await _infoServiceWrapper.GenerateImageData1(request.AccountId, request.ComputerName);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new GenerateImageData1Response
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                PrintTemplateData = response
            });
        }
    }
}