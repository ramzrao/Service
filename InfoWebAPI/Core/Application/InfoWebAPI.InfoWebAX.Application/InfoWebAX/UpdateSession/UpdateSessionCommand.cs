using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class UpdateSessionCommand : IRequestHandler<UpdateSessionRequest, UpdateSessionResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public UpdateSessionCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<UpdateSessionResponse> Handle(UpdateSessionRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            var response = 0;
            try
            {
                response = await _infoServiceWrapper.UpdateSession(request.AccountId, request.SessionCode, request.SessionName, request.SessionDate, request.SessionStartTime,
                    request.SessionEndTime, request.Score, request.IsDuplicateScoreAllowed, request.ExitFor, request.AttendingAnswerCode, request.AttendedAnswerCode, request.Room, request.SessionKey);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new UpdateSessionResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                UpdateSessionResult = response
            });
        }
    }
}