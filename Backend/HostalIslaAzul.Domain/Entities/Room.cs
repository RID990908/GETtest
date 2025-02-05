namespace HostalIslaAzul.Domain.Entities;

public class Room : BaseEntity
{
    public int Number { get; set; }
    public int Floor { get; set; }
    public bool OutOfService { get; set; }
    public decimal PricePerDay { get; set; }
}