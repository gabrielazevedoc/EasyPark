namespace EasyParkAPI.InputModel
{
    public class ReservaInputModel
    {

        public DateTime DataReserva { get; set; }
        public int UsuarioId { get; set; }
        public int CarroId { get; set; }
        public int VagaId { get; set; }
    }
}
