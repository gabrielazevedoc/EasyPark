using System.ComponentModel.DataAnnotations;

namespace EasyParkAPI.Model
{
    public class CarroModel
    {

        public int Id { get;  private set; }
        public string Modelo { get; private set; }
        public string Placa { get; private set; }
        public int UsuarioId { get; set; }
        public UsuarioModel Usuario { get; set; }
    }
}