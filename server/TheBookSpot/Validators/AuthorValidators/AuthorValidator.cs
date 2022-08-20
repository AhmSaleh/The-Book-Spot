using FluentValidation;
using TheBookSpotDomain.Validators;

namespace TheBookSpot.Validators.AuthorValidators
{
    public class AuthorValidator : AbstractValidator<DTOs.AuthorDTOs.Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty()
              .Must(x => x.ContainsCharsOnly())
              .WithMessage("FirstName must contains only alphabet characters");

            RuleFor(x => x.LastName).NotEmpty()
                .Must(x => x.ContainsCharsOnly())
                .WithMessage("LastName must contains only alphabet characters");

        }
    }
}
