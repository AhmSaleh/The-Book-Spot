using FluentValidation;
using TheBookSpotDomain.Validators;

namespace TheBookSpot.Validators.AuthorValidators
{
    public class UpdateAuthorRequestValidator : AbstractValidator<DTOs.AuthorDTOs.UpdateAuthorRequest>
    {
        public UpdateAuthorRequestValidator()
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
