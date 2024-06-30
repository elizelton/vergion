using BuildingBlocks.Domain;

namespace Vergion.Domain.Entities;

public class FinancialGoal : Entity
{
    public required string Description { get; set; }
    public required decimal TargetAmount { get; set; }
    public required decimal CurrentAmount { get; set; }
    public required DateTime TargetDate { get; set; }
}