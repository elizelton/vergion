using FluentValidation;
using MediatR;
using Vergion.Domain.Commands.Transaction;

namespace Vergion.Application.CommandHandlers.Transaction;

public class AddNewTransactionCommandHandler(
    IMediator mediator,
    IValidator<AddNewTransactionCommand> validator) : IRequestHandler<AddNewTransactionCommand>
{
    private readonly IMediator _mediator = mediator;

    public async Task Handle(AddNewTransactionCommand request, CancellationToken cancellationToken)
    {
        if (!(await validator.ValidateAsync(request, cancellationToken)).IsValid)
        {
            
        }
    }
}