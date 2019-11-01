using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class InsertSessionCommand : IRequestHandler<InsertSessionRequest, InsertSessionResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public InsertSessionCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<InsertSessionResponse> Handle(InsertSessionRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            var response = 0;
            try
            {
                response = await _infoServiceWrapper.InsertSession(request.AccountId, request.SessionCode, request.SessionName, request.SessionDate, request.StartTime, request.EndTime,
                    request.Score, request.AllowDupYN, request.ExitFor, request.AttendingCode, request.AttendedCode, request.Room);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new InsertSessionResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                InsertSessionResult = response
            });
        }
    }
}