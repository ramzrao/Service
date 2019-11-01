using FluentValidation;
using MediatR;

namespace InfoWebAPI.Core.Application.AccountUser
{
    public class ListAccountUserRequest : IRequest<ListAccountUserResponse>
    {
        public int AccountId { get; set; }
    }

    public class ListAccountUserRequestValidator : AbstractValidator<ListAccountUserRequest>
    {
        public ListAccountUserRequestValidator()
        {
            RuleFor(e => e.AccountId)
                .GreaterThan(0)
                .NotEmpty();
        }
    }
}