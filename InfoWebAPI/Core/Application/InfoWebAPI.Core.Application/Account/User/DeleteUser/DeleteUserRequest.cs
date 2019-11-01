using FluentValidation;
using MediatR;

namespace InfoWebAPI.Core.Application.User
{
    public class DeleteUserRequest : IRequest<DeleteUserResponse>
    {
        public int UserId { get; set; }
    }

    public class DeleteUserRequestValidator : AbstractValidator<DeleteUserRequest>
    {
        public DeleteUserRequestValidator()
        {
            RuleFor(e => e.UserId)
                .GreaterThan(0)
                .NotEmpty();
        }
    }
}