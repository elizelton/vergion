using BuildingBlocks.Domain;

namespace Vergion.Domain.Entities;

public class Budget : Entity
{
    public required string Category { get; set; }
    public required decimal Amount { get; set; }
    public required DateTime Month { get; set; }
}