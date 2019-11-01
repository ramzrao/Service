using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InfoWebAPI.InfoWebAX.Application
{
    public class SavePhotoCommand : IRequestHandler<SavePhotoRequest, SavePhotoResponse>
    {
        private readonly IMediator _mediator;
        private readonly IInfoWebAXWrapper _infoServiceWrapper;

        public SavePhotoCommand(IMediator mediator, IInfoWebAXWrapper infoServiceWrapper)
        {
            _infoServiceWrapper = infoServiceWrapper;
            _mediator = mediator;
        }

        public async Task<SavePhotoResponse> Handle(SavePhotoRequest request, CancellationToken cancellationToken)
        {
            var errorMessage = string.Empty;
            var response = false;
            try
            {
                response = await _infoServiceWrapper.SavePhoto(request.AccountId, request.ContactKey, request.binaryData);
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
            }
            return await Task.FromResult(new SavePhotoResponse
            {
                IsServiceCallSuccess = string.IsNullOrEmpty(errorMessage) ? true : false,
                ErrorMessage = errorMessage,
                SavePhotoResult = response
            });
        }
    }
}