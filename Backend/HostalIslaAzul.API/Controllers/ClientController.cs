using HostalIslaAzul.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HostalIslaAzul.API.Controllers;

[Authorize(Roles = "Admin,Recepcionista")]
public class ClienteController : ControllerBase
{
    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> CreateClient([FromBody] Client client)
    {
        // Solo usuarios con rol Admin pueden crear clientes
        try
        {
            // Lógica para crear un cliente
            return Ok("Cliente creado exitosamente");
        }
        catch (Exception ex)
        {
            // Manejo de errores
            return BadRequest(ex.Message);
        }
    }

    [HttpGet]
    [Authorize(Roles = "Admin,Recepcionista")]
    public async Task<IActionResult> GetClient()
    {
        // Usuarios Admin y Recepcionista pueden ver clientes
        try
        {
            // Lógica para obtener clientes
            return Ok("Clientes obtenidos exitosamente");
        }
        catch (Exception ex)
        {
            // Manejo de errores
            return BadRequest(ex.Message);
        }
    }
}