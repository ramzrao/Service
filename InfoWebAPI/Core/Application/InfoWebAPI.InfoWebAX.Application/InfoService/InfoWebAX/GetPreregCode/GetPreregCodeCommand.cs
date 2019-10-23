using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.Application.InfoService.InfoWebAX
{
    public class GetPreregCodeCommand : IRequestHandler<GetPreregCodeRequest, GetPreregCodeResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public GetPreregCodeCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<GetPreregCodeResponse> Handle(GetPreregCodeRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            try
            {
                var response = await _infoServiceWrapper.GetPreregCode(request.AccountId);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new GetPreregCodeResponse
            {
                Success = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage
            });
        }
    }
}