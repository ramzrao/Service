using InfoWebAPI.Application.InfoService.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class GenerateImageDataWrapCommand : IRequestHandler<GenerateImageDataWrapRequest, GenerateImageDataWrapResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public GenerateImageDataWrapCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<GenerateImageDataWrapResponse> Handle(GenerateImageDataWrapRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            List<PrintTemplateData> response = new List<PrintTemplateData>();
            try
            {
                response = await _infoServiceWrapper.GenerateImageDataWrap(request.AccountId, request.CardNumber,request.TemplateId,request.ComputerName);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new GenerateImageDataWrapResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                PrintTemplateData = response
            });
        }
    }
}