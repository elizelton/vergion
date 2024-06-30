using FluentValidation;

namespace Vergion.Domain.Commands.Transaction;

public sealed class AddNewTransactionCommandValidator : AbstractValidator<AddNewTransactionCommand>
{
    public AddNewTransactionCommandValidator()
    {
        RuleFor(x => x.Account)
            .NotEmpty().WithMessage("Account is required.");

        RuleFor(x => x.Amount)
            .GreaterThan(0).WithMessage("Amount must be a positive number.");

        RuleFor(x => x.Date)
            .NotEmpty().WithMessage("Date is required.");
    }
}