using EasyParkAPI.Model;
using EasyParkAPI.Services.Carro;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyParkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarroController : ControllerBase
    {
        private readonly ICarroService _carroService;

        public CarroController(ICarroService carroService)
        {
            _carroService = carroService;
        }

        [HttpPost]
        public async Task<IActionResult> AddCarro([FromBody] CarroModel carro)
        {
            var result = await _carroService.AddCarroAsync(carro);
            return Ok(result);
        }

        [HttpGet("{usuarioId}")]
        public async Task<IActionResult> GetCarros(int usuarioId)
        {
            var carros = await _carroService.GetCarrosByUsuarioIdAsync(usuarioId);
            return Ok(carros);
        }
    }
}
