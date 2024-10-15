using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EasyParkAPI.Model
{
    public class UsuarioModel
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public ICollection<CarroModel> Carros { get; set; }
        public ICollection<ReservaModel> Reservas { get; set; }


    }
}
