using FluentValidation;
using WebApplication2.DTOs;

namespace WebApplication2.Validators
{
    public class CreateUserDtoValidator: AbstractValidator<CreateUserDto>
    {
        public CreateUserDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MinimumLength(3)
                .MaximumLength(50);

            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();

            RuleFor(x => x.Password)
                .NotEmpty()
                .MinimumLength(6);
        }
    }
}
