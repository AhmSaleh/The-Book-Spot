using FluentValidation;
using TheBookSpot.DTOs.BookDTOs;

namespace TheBookSpot.Validators.BookValidators
{
    public class AddBookRequestValidator : AbstractValidator<AddBookRequest>
    {
        public AddBookRequestValidator()
        {
            RuleFor(x => x.Title).NotEmpty();
            RuleFor(x => x.ISBN).NotEmpty();
            RuleFor(x => x.PublicationYear)
                .GreaterThanOrEqualTo(1700)
                .LessThanOrEqualTo(DateTime.Now.Year);

            RuleFor(x => x.Price)
                .GreaterThan(0);

        }
    }
}
