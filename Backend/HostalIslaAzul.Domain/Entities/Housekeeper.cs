namespace HostalIslaAzul.Domain.Entities;

public class Housekeeper : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string CI { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public List<Room> AssignedRooms { get; set; } = [];
}