using FluentValidation;
using MediatR;

namespace InfoWebAPI.Core.Application.AccountUser
{
    public class DeleteAccountUserRequest : IRequest<DeleteAccountUserResponse>
    {
        public int AccountId { get; set; }
        public int UserId { get; set; }
    }

    public class DeleteAccountUserRequestValidator : AbstractValidator<DeleteAccountUserRequest>
    {
        public DeleteAccountUserRequestValidator()
        {
            RuleFor(e => e.AccountId)
                .GreaterThan(0)
                .NotEmpty();

            RuleFor(e => e.UserId)
                .GreaterThan(0)
                .NotEmpty();
        }
    }
}