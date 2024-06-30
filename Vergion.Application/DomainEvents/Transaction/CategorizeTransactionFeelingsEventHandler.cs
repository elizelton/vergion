using MediatR;
using Vergion.Domain.Events.Transaction;

namespace Vergion.Application.DomainEvents.Transaction;

public class CategorizeTransactionFeelingsEventHandler : INotificationHandler<AddNewTransactionEvent>
{
    
    public Task Handle(AddNewTransactionEvent notification, CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
}