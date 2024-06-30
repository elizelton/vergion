using BuildingBlocks.Domain;

namespace Vergion.Domain.Entities;

public class Transaction : AggregateRoot
{
    public required string Account { get; set; }
    public required decimal Amount { get; set; }
    public required DateTime Date { get; set; }
    public required string Category { get; set; }
}