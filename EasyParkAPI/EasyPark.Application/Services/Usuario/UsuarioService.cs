using EasyParkAPI.Infrastructure;
using EasyParkAPI.InputModel;
using EasyParkAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace EasyParkAPI.Services.Usuario
{
    public class UsuarioService : IUsuarioService
    {
        private readonly ConnectionContext _context;

        public UsuarioService(ConnectionContext context)
        {
            _context = context;
        }

        public async Task<UsuarioModel> CadastrarAsync(UsuarioModel usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
            return usuario;
        }

        public UsuarioModel Login(string email, string senha)
        {
            return _context.Usuarios
           .FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public async Task<UsuarioModel> GetByIdAsync(int id)
        {
            return await _context.Usuarios
                .Include(u => u.Carros)
                .FirstOrDefaultAsync(u => u.Id == id);
        }
    }
}
