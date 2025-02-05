namespace HostalIslaAzul.Domain.Entities;

public class Reserve : BaseEntity
{
    public DateTime ReservationDate { get; set; }
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public decimal TotalAmount { get; set; }
    public Client Client { get; set; } = new Client();
    public Room Room { get; set; } = new Room();
    public bool IsClientInHostal { get; set; }
    public bool IsCancelled { get; set; }
    public DateTime? CancellationDate { get; set; }
    public string CancellationReason { get; set; } = string.Empty;
}