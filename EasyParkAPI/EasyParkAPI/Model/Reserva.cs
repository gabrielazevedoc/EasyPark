using System.ComponentModel.DataAnnotations.Schema;

namespace EasyParkAPI.Model
{
    public class Reserva
    {
        public int IdReserva { get; set; }

        public int IdCarro { get; set; }
    }
}
