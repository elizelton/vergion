namespace BuildingBlocks.Domain;

public abstract class IntegrationEvent : IIntegrationEvent
{
    public DateTime OccurredOn { get; } = DateTime.UtcNow;
}