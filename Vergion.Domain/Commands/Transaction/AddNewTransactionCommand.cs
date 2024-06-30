using MediatR;

namespace Vergion.Domain.Commands.Transaction;

public sealed record AddNewTransactionCommand : IRequest
{
    public required string Account { get; set; }
    public required decimal Amount { get; set; }
    public required DateTime Date { get; set; }
}