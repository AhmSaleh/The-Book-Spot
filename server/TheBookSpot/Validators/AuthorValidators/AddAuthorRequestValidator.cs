using FluentValidation;
using TheBookSpotDomain.Validators;

namespace TheBookSpot.Validators.AuthorValidators
{
    public class AddAuthorRequestValidator : AbstractValidator<DTOs.AuthorDTOs.AddAuthorRequest>
    {
        public AddAuthorRequestValidator()
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
