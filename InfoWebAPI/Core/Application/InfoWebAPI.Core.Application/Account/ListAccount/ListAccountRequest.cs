using FluentValidation;
using MediatR;

namespace InfoWebAPI.Application.ListAccount
{
    public class ListAccountRequest : IRequest<ListAccountResponse>
    {
        public int UserId { get; set; }
    }

    public class ListAccountRequestValidator : AbstractValidator<ListAccountRequest>
    {
        public ListAccountRequestValidator()
        {
            RuleFor(e => e.UserId)
                .GreaterThan(0)
                .NotEmpty();
        }
    }
}