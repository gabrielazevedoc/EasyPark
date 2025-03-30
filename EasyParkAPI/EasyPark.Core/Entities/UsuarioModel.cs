using EasyPark.Core.Entities;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EasyPark.Core.Entities
{
    public class UsuarioModel : BaseEntity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public List<CarroModel> Carros { get; set; }
        public List<ReservaModel> Reservas { get; set; }

        public UsuarioModel() { }

        public UsuarioModel(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Carros = new List<CarroModel>();
            Reservas = new List<ReservaModel>();
        }


    }
}
