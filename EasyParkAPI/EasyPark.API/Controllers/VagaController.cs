using EasyPark.Application.Services.Vaga;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EasyParkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VagaController : ControllerBase
    {
        private readonly IVagaService _vagaService;

        public VagaController(IVagaService vagaService)
        {
            _vagaService = vagaService;
        }

        [HttpGet]
        public async Task<IActionResult> GetVagasDisponiveis()
        {
            var vagas = await _vagaService.GetVagasAsync();
            return Ok(vagas);
        }
    }
}
