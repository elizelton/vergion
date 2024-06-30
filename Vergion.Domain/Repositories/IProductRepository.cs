using Vergion.Domain.Entities;

namespace Vergion.Domain.Repositories;

public interface IProductRepository
{
    Task SaveProductAsync(Product product);
}