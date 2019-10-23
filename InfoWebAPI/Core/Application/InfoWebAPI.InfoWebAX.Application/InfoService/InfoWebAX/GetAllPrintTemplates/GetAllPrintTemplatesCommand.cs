using InfoWebAPI.Application.InfoService.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetAllPrintTemplatesCommand : IRequestHandler<GetAllPrintTemplatesRequest, GetAllPrintTemplatesResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public GetAllPrintTemplatesCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<GetAllPrintTemplatesResponse> Handle(GetAllPrintTemplatesRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            List<PrintTemplate> response = new List<PrintTemplate>();
            try
            {
                response = await _infoServiceWrapper.GetAllPrintTemplates(request.AccountId);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new GetAllPrintTemplatesResponse
            {
                Success = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                PrintTemplateList = response
            });
        }
    }
}