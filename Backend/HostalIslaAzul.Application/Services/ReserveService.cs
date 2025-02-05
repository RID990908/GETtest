using HostalIslaAzul.Application.DTOs;
using HostalIslaAzul.Domain.Entities;
using HostalIslaAzul.Domain.Interfaces;
using Microsoft.Extensions.Logging;

namespace HostalIslaAzul.Application.Services;

public class ReserveService : IReserveService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<ReserveService> _logger;

    public async Task<Reserve> MakeAReservation(ReserveDto reserveDto)
    {
        try 
        {
            var client = await _unitOfWork.Repository<Client>().GetByIdAsync(reserveDto.ClientId);
            var room = await _unitOfWork.Repository<Room>().GetByIdAsync(reserveDto.RoomId);

            var reserva = new Reserve 
            {
                Client = client,
                Room = room,
                CheckInDate = reserveDto.CheckInDate,
                CheckOutDate = reserveDto.CheckOutDate,
                TotalAmount = CalcularImporteReserva(reserveDto, client)
            };

            await _unitOfWork.Repository<Reserve>().AddAsync(reserva);
            await _unitOfWork.SaveChangesAsync();

            return reserva;
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error en reserva: {ex.Message}");
            throw;
        }
    }
    private decimal CalcularImporteReserva(ReserveDto reserveDto, Client client)
{
    // Implement the logic to calculate the reservation amount
    return 0; // Example value
}
}