using EasyParkAPI.Model;

namespace EasyParkAPI.Services.Reserva
{
    public interface IReservaService
    {
        Task<ReservaModel> CriarReservaAsync(ReservaModel reserva);
        Task<IEnumerable<ReservaModel>> GetReservasByUsuarioIdAsync(int usuarioId);
    }
}
