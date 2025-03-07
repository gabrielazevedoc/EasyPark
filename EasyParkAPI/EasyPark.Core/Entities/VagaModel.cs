using EasyPark.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace EasyPark.Core.Entities
{
    public class VagaModel : BaseEntity
    {
        public bool Disponivel { get; set; }
        public List<ReservaModel> Reservas { get; set; }
    }
}
