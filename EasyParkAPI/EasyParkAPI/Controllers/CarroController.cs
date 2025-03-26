using EasyPark.Application.DTO;
using EasyPark.Core.Entities;
using EasyPark.Application.Services.Carro;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyPark.Application.Controllers
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
        public async Task<IActionResult> AddCarro(CarroInputModel carroInputModel)
        {

            var carro = new CarroModel
            {
                Placa = carroInputModel.Placa,
                Modelo = carroInputModel.Modelo,
            };

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
