using HostalIslaAzul.Application.DTOs;
using HostalIslaAzul.Domain.Entities;

namespace HostalIslaAzul.Domain.Interfaces;

public interface IReserveService
{
    Task<Reserve> MakeAReservation(ReserveDto reserve);
}