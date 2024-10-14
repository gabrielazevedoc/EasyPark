using EasyParkAPI.InputModel;
using EasyParkAPI.Model;

namespace EasyParkAPI.Services.Usuario
{
    public interface IUsuarioInterface
    {
        Task<ResponseModel<List<UsuarioModel>>> AdicionarUsuario(UsuarioInputModel usuarioInputModel);
    }
}
