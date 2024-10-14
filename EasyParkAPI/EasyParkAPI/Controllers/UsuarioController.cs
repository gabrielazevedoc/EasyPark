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
        private readonly IUsuarioInterface _usuarioInterface;

        public UsuarioController(IUsuarioInterface usuarioInterface)
        {
            _usuarioInterface = usuarioInterface;
        }

        [HttpPost]
        public async Task<ActionResult<ResponseModel<UsuarioModel>>> AdicionarUsuario(UsuarioInputModel usuarioInputModel)
        {
            var usuarios = await _usuarioInterface.AdicionarUsuario(usuarioInputModel);
            return Ok(usuarios);
        }





    }
}
