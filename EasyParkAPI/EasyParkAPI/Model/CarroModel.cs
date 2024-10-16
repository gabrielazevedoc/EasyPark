using System.ComponentModel.DataAnnotations;

namespace EasyParkAPI.Model
{
    public class CarroModel
    {

        public int Id { get; set; }
        public string Modelo { get;  set; }
        public string Placa { get; set; }
        public int UsuarioId { get; set; }
        public UsuarioModel Usuario { get; set; }
    }
}