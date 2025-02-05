namespace HostalIslaAzul.Application.DTOs;

public class ReserveDto
{
    public DateTime CheckInDate { get; set; }
    public DateTime CheckOutDate { get; set; }
    public int ClientId { get; set; }
    public int RoomId { get; set; }
}