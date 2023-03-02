using BC.Common.DTO.Book;
using FluentValidation;

namespace BookCritic.Validators
{
    public sealed class NewBookDTOValidator : AbstractValidator<NewBookDTO>
    {
        public NewBookDTOValidator()
        {
            RuleFor(b => b.Author)
                .NotEmpty()
                    .WithMessage("Author must be provided");

            RuleFor(b => b.Title)
                .NotEmpty()
                    .WithMessage("Title must be provided");

            RuleFor(b => b.Cover)
                .Must(uri => Uri.TryCreate(uri, UriKind.Absolute, out _))
                .When(x => !string.IsNullOrEmpty(x.Cover));

        }
    }
}
