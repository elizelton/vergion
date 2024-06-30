using BuildingBlocks.Domain;

namespace Vergion.Domain.Events.Transaction;

public class AddNewTransactionEvent(string account, decimal amount, DateTime date, DateTime occurredOn) : IDomainEvent
{
    public string Account { get; set; } = account;
    public decimal Amount { get; set; } = amount;
    public DateTime Date { get; set; } = date;
    public DateTime OccurredOn { get; } = occurredOn;
}