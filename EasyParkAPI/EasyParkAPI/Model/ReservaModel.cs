using System.ComponentModel.DataAnnotations.Schema;

namespace EasyParkAPI.Model
{
    public class ReservaModel
    {
        public int Id { get; set; }

        public UsuarioModel Usuario { get; set; }
        public CarroModel Carro { get; set; }
    }
}
