using FluentValidation;

namespace TheBookSpot.Validators.BookValidators
{
    public class BookAuthorRequestValidator : AbstractValidator<DTOs.BookDTOs.UpdateBookRequest>
    {
        public BookAuthorRequestValidator()
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
