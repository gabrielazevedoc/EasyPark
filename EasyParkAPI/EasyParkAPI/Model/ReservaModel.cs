using System.ComponentModel.DataAnnotations.Schema;

namespace EasyParkAPI.Model
{
    public class ReservaModel
    {
        public int Id { get; set; }
        public DateTime DataReserva { get; set; }
        public int UsuarioId { get; set; }
        public UsuarioModel Usuario { get; set; }
        public int VagaId { get; set; }
        public VagaModel Vaga { get; set; }
        public int CarroId { get; set; }
        public CarroModel Carro { get; set; }
    }
}
