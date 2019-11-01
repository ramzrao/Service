using InfoWebAPI.Application.InfoService.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GenerateImageData2Command : IRequestHandler<GenerateImageData2Request, GenerateImageData2Response>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public GenerateImageData2Command(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<GenerateImageData2Response> Handle(GenerateImageData2Request request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            List<PrintTemplateData> response = new List<PrintTemplateData>();
            try
            {
                response = await _infoServiceWrapper.GenerateImageData2(request.AccountId, request.PrintTemplateId, request.ComputerName);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new GenerateImageData2Response
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                PrintTemplateData = response
            });
        }
    }
}