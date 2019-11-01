using FluentValidation;
using MediatR;

namespace InfoWebAPI.Core.Application.User
{
    public class GetUserRequest : IRequest<GetUserResponse>
    {
        public int UserId { get; set; }
    }

    public class GetUserRequestValidator : AbstractValidator<GetUserRequest>
    {
        public GetUserRequestValidator()
        {
            RuleFor(e => e.UserId)
                .GreaterThan(0)
                .NotEmpty();
        }
    }
}