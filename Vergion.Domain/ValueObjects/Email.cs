using BuildingBlocks.Domain;

namespace Vergion.Domain.ValueObjects;

public class Email(string emailAddress) : ValueObject
{
    private string EmailAddress { get; set; } = emailAddress;
    
    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return EmailAddress;
    }
}
