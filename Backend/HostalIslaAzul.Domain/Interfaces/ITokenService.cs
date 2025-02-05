using HostalIslaAzul.Domain.Entities;

namespace HostalIslaAzul.Domain.Interfaces;

public interface ITokenService
{
    string GenerateJwtToken(User user);
}