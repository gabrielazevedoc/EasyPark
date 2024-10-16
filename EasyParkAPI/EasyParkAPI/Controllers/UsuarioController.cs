using EasyParkAPI.InputModel;
using EasyParkAPI.Model;
using EasyParkAPI.Services.Usuario;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace EasyParkAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpPost("cadastrar")]
        public async Task<IActionResult> Cadastrar(UsuarioInputModel usuarioInputModel)
        {
            var usuario = new UsuarioModel
            {
                Nome = usuarioInputModel.Nome,
                Email = usuarioInputModel.Email,
                Senha = usuarioInputModel.Senha
            };

            var result = await _usuarioService.CadastrarAsync(usuario);
            return Ok(result);
        }

        [HttpPost("login")]
        public IActionResult Login(UsuarioInputModel usuarioInputModel)
        {
            var user = _usuarioService.Login(usuarioInputModel.Email, usuarioInputModel.Senha);
            if (user == null) return Unauthorized();
            return Ok(user);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUsuario(int id)
        {
            var usuario = await _usuarioService.GetByIdAsync(id);
            if (usuario == null) return NotFound();
            return Ok(usuario);
        }





    }
}
