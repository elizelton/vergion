using BuildingBlocks.Domain;
using Vergion.Domain.ValueObjects;

namespace Vergion.Domain.Entities;

public class Supplier : Entity
{
    public required string Name { get; set; }
    public required Email Email { get; set; }
    public IReadOnlyCollection<Product> ProductsSupplied => _productsSupplied?.ToArray() ?? [];
    private List<Product>? _productsSupplied { get; set; }

    public void SupplyProduct(Product product, int quantity)
    {
        product.StockLevel += quantity;
        
        _productsSupplied ??= [];
        _productsSupplied.Add(product);
    }
}