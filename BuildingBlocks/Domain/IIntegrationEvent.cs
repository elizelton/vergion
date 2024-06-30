using MediatR;

namespace BuildingBlocks.Domain;

public interface IIntegrationEvent: INotification
{
    DateTime OccurredOn { get; }
}