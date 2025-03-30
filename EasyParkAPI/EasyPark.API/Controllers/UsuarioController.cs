
using EasyPark.Application.DTO;
using EasyPark.Application.Services.Usuario;
using EasyPark.Core.Entities;
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
        public IActionResult Login(LoginInputModel loginInputModel)
        {
            UsuarioModel usuario = new UsuarioModel
            {
                Email = loginInputModel.Email,
                Senha = loginInputModel.Senha
            };

            var user = _usuarioService.Login(usuario.Email, usuario.Senha);
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
