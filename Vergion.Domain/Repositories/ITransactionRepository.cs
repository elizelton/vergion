using Vergion.Domain.Entities;

namespace Vergion.Domain.Repositories;

public interface ITransactionRepository
{
    Task SaveTransactionAsync(Transaction transaction);
}