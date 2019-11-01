using FluentValidation;
using MediatR;

namespace InfoWebAPI.Core.Application.User
{
    public class AddUserRequest : IRequest<AddUserResponse>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool IsAdmin { get; set; }
    }

    public class AddUserRequestValidator : AbstractValidator<AddUserRequest>
    {
        public AddUserRequestValidator()
        {
            RuleFor(e => e.UserName)
                .NotEmpty();
            RuleFor(e => e.Password)
                .NotEmpty();
            RuleFor(e => e.FullName)
                .NotEmpty();
        }
    }
}