using FluentValidation;
using WebApplication2.DTOs;

namespace WebApplication2.Validators
{
    public class UpdateUserDtoValidator : AbstractValidator<UpdateUserDto>
    {
        public UpdateUserDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .MinimumLength(3);

            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();
        }
    }
}
