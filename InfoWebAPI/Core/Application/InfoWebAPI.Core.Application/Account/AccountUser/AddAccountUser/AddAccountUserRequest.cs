using FluentValidation;
using MediatR;

namespace InfoWebAPI.Core.Application.AccountUser
{
    public class AddAccountUserRequest : IRequest<AddAccountUserResponse>
    {
        public int AccountId { get; set; }
        public int UserId { get; set; }
    }

    public class AddAccountUserRequestValidator : AbstractValidator<AddAccountUserRequest>
    {
        public AddAccountUserRequestValidator()
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