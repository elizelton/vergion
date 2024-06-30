using System.Collections.ObjectModel;

namespace BuildingBlocks.Domain;

public abstract class Entity
{
    private Guid Id { get; } = Guid.NewGuid();

    public override bool Equals(object? obj)
    {
        if (obj is not Entity entity)
            return false;

        if (ReferenceEquals(this, entity))
            return true;

        return Id == entity.Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode();
    }
}
