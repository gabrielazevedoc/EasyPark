using System.ComponentModel.DataAnnotations;

namespace EasyParkAPI.Model
{
    public class VagaModel
    {
        public int Id { get; set; }
        public bool Disponivel { get; set; }
        public ICollection<ReservaModel> Reservas { get; set; }
    }
}
