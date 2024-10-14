using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace EasyParkAPI.Model
{
    public class UsuarioModel
    {

        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }

        [JsonIgnore]
        public List<CarroModel> Carros { get; set; }

       
    }
}
