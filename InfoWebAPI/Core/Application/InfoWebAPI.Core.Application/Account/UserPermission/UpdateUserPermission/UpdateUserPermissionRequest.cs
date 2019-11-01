using FluentValidation;
using MediatR;

namespace InfoWebAPI.Core.Application.UserPermission
{
    public class UpdateUserPermissionRequest : IRequest<UpdateUserPermissionResponse>
    {
        public int UserId { get; set; }
        public int PermissionId { get; set; }
        public bool PermissionValue { get; set; }
    }

    public class UpdateUserPermissionRequestValidator : AbstractValidator<UpdateUserPermissionRequest>
    {
        public UpdateUserPermissionRequestValidator()
        {
            RuleFor(e => e.UserId)
                .GreaterThan(0)
                .NotEmpty();
            RuleFor(e => e.PermissionId)
                .GreaterThan(0)
                .NotEmpty();
            RuleFor(e => e.PermissionValue)
                .NotEmpty();
        }
    }
}