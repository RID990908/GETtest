namespace HostalIslaAzul.Domain.Entities;

public class Client : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string LastName { get; set; } =string.Empty;
    public string CI { get; set; } = string.Empty;
    public string PhoneNumber { get; set; }= string.Empty;
    public bool IsVIP { get; set; }
}