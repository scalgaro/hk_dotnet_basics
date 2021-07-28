using FluentValidation;
using VideoFluentValidation.Contracts.Requests;

namespace VideoFluentValidation.Validators
{
    public class CreateUserRequestValidator : AbstractValidator<CreateUserRequest>
    {
        public CreateUserRequestValidator()
        {
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();
            RuleFor(x => x.Age)
                .NotEmpty()
                .GreaterThanOrEqualTo(18);
            RuleFor(x => x.UserName)
                .NotEmpty()
                .MinimumLength(8);
            RuleFor(x => x.FullName)
                .NotEmpty();
        }
    }
}