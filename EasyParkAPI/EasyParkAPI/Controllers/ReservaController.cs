using EasyParkAPI.Model;
using EasyParkAPI.Services.Reserva;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyParkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private readonly IReservaService _reservaService;

        public ReservaController(IReservaService reservaService)
        {
            _reservaService = reservaService;
        }

        [HttpPost]
        public async Task<IActionResult> CriarReserva([FromBody] ReservaModel reserva)
        {
            try
            {
                var result = await _reservaService.CriarReservaAsync(reserva);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{usuarioId}")]
        public async Task<IActionResult> GetReservas(int usuarioId)
        {
            var reservas = await _reservaService.GetReservasByUsuarioIdAsync(usuarioId);
            return Ok(reservas);
        }
    }
}
