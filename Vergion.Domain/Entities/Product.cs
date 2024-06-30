using BuildingBlocks.Domain;

namespace Vergion.Domain.Entities;

public class Product : Entity
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    public float MinimalStockLevel { get; set; }
    public float StockLevel { get; set; }

    public void UpdateStockLevel(float quantity)
    {
        StockLevel = quantity;

        if (StockLevel >= MinimalStockLevel)
        {
            NotifyLowStock();
        }
    }

    private void NotifyLowStock()
    {
        throw new NotImplementedException();
    }
}