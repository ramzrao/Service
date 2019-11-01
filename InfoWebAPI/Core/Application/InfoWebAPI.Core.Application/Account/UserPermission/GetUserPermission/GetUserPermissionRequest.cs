using FluentValidation;
using MediatR;

namespace InfoWebAPI.Core.Application.UserPermission
{
    public class GetUserPermissionRequest : IRequest<GetUserPermissionResponse>
    {
        public int UserId { get; set; }
    }

    public class UserPermissionRequestValidator : AbstractValidator<GetUserPermissionRequest>
    {
        public UserPermissionRequestValidator()
        {
            RuleFor(e => e.UserId)
                .GreaterThan(0)
                .NotEmpty();
        }
    }
}