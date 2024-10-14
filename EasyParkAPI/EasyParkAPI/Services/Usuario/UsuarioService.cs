using EasyParkAPI.Infrastructure;
using EasyParkAPI.InputModel;
using EasyParkAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace EasyParkAPI.Services.Usuario
{
    public class UsuarioService : IUsuarioInterface
    {
        private readonly ConnectionContext _context;

        public UsuarioService(ConnectionContext context)
        {
            _context = context;
        }
        public async Task<ResponseModel<List<UsuarioModel>>> AdicionarUsuario(UsuarioInputModel usuarioInputModel)
        {
            ResponseModel<List<UsuarioModel>> resposta = new ResponseModel<List<UsuarioModel>>();

            try
            {
                var usuario = new UsuarioModel()
                {
                    Nome = usuarioInputModel.Nome,
                    Cpf = usuarioInputModel.Cpf,
                    Senha = usuarioInputModel.Senha,
                };


                _context.Add(usuario);
                await _context.SaveChangesAsync();

                resposta.Dados = await _context.Usuarios.ToListAsync();
                resposta.Mensagem = "Usuario cadastrado";

                return resposta;

            }
            catch (Exception ex)
            {

                resposta.Mensagem = ex.Message;
                resposta.Status = false;
                return resposta;
            }
        }
    }
}
