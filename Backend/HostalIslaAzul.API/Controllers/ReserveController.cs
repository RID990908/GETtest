using HostalIslaAzul.Application.DTOs;
using HostalIslaAzul.Domain.Entities;
using HostalIslaAzul.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HostalIslaAzul.API.Controllers;

public class ReserveController : ControllerBase
{
    private readonly IReserveService _reservaService;
    private readonly ILogger<ReserveController> _logger;

    [HttpPost]
    public async Task<IActionResult> CreateReserve([FromBody] ReserveDto reserve)
    {
        try
        {
            var result = await _reservaService.MakeAReservation(reserve);
            return Ok(result);
        }
        catch (Exception ex)
        {
            _logger.LogError($"Error en reserva: {ex.Message}");
            return BadRequest(ex.Message);
        }
    }
}