using EasyPark.Core.Entities;

namespace EasyPark.Application.Services.Usuario
{
    public interface IUsuarioService
    {
        Task<UsuarioModel> CadastrarAsync(UsuarioModel usuario);
        UsuarioModel Login(string email, string senha);
        Task<UsuarioModel> GetByIdAsync(int id);
    }
}
