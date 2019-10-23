using FluentValidation;
using MediatR;

namespace InfoWebAPI.Application.UserPermission
{
    public class UserPermissionRequest : IRequest<UserPermissionResponse>
    {
        public int UserId { get; set; }
    }

    public class UserPermissionRequestValidator : AbstractValidator<UserPermissionRequest>
    {
        public UserPermissionRequestValidator()
        {
            RuleFor(e => e.UserId)
                .GreaterThan(0)
                .NotEmpty();
        }
    }
}