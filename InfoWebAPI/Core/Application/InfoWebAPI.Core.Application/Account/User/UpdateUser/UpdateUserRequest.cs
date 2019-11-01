using FluentValidation;
using MediatR;

namespace InfoWebAPI.Core.Application.User
{
    public class UpdateUserRequest : IRequest<UpdateUserResponse>
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
    }

    public class UpdateUserRequestValidator : AbstractValidator<UpdateUserRequest>
    {
        public UpdateUserRequestValidator()
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