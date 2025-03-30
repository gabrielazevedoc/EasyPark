using EasyPark.Application.DTO;
using EasyPark.Application.Services.Reserva;
using EasyPark.Core.Entities;
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
        public async Task<IActionResult> CriarReserva(ReservaInputModel reservaInputModel)
        {
            var reserva = new ReservaModel
            {
                DataReserva = DateTime.Now,
                UsuarioId = reservaInputModel.UsuarioId,
                CarroId = reservaInputModel.CarroId,
                VagaId = reservaInputModel.VagaId
            };

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
