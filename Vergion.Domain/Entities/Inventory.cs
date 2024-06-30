using BuildingBlocks.Domain;

namespace Vergion.Domain.Entities;

public class Inventory : Entity
{
    public virtual required Product Product { get; set; }
    public Guid ProductId { get; set; }
    public float StockLevel { get; set; }
    public DateTime LastUpdate { get; set; }
}