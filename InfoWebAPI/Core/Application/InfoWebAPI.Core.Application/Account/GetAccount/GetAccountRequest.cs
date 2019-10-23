using FluentValidation;
using MediatR;

namespace InfoWebAPI.Application.GetAccount
{
    public class GetAccountRequest : IRequest<GetAccountResponse>
    {
        public int AccountId { get; set; }
    }

    public class GetAccountRequestValidator : AbstractValidator<GetAccountRequest>
    {
        public GetAccountRequestValidator()
        {
            RuleFor(e => e.AccountId)
                .GreaterThan(0)
                .NotEmpty();
        }
    }
}