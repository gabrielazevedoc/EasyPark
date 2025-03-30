using EasyPark.Core.Entities;

namespace EasyPark.Application.Services.Reserva
{
    public interface IReservaService
    {
        Task<ReservaModel> CriarReservaAsync(ReservaModel reserva);
        Task<IEnumerable<ReservaModel>> GetReservasByUsuarioIdAsync(int usuarioId);
    }
}
