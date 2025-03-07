using EasyPark.Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyPark.Core.Entities
{
    public class ReservaModel : BaseEntity
    {
        public ReservaModel()
        {
            // Inicialização de coleções, caso haja necessidade futura
        }

#nullable enable
        public DateTime DataReserva { get; set; }
        public int UsuarioId { get; set; }
        public int VagaId { get; set; }
        public int CarroId { get; set; }

        #region Generated Relationships
        public virtual UsuarioModel? Usuario { get; set; }
        public virtual VagaModel? Vaga { get; set; }
        public virtual CarroModel? Carro { get; set; }
        #endregion
    }
}
