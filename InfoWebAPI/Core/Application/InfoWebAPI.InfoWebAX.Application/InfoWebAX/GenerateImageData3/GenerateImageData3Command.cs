using InfoWebAPI.Application.InfoService.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GenerateImageData3Command : IRequestHandler<GenerateImageData3Request, GenerateImageData3Response>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public GenerateImageData3Command(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<GenerateImageData3Response> Handle(GenerateImageData3Request request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            List<PrintTemplateData> response = new List<PrintTemplateData>();
            try
            {
                response = await _infoServiceWrapper.GenerateImageData3(request.AccountId, request.ContactKey,request.ComputerName);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new GenerateImageData3Response
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                PrintTemplateData = response
            });
        }
    }
}