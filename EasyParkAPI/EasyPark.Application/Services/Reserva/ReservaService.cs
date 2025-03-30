using EasyPark.Core.Entities;
using EasyPark.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace EasyPark.Application.Services.Reserva
{
    public class ReservaService : IReservaService
    {

        private readonly EasyParkContext _context;

        public ReservaService(EasyParkContext context)
        {
            _context = context;
        }
        public async Task<ReservaModel> CriarReservaAsync(ReservaModel reserva)
        {
            try
            {
                var vaga = await _context.Vagas.FindAsync(reserva.VagaId);
                if (vaga == null || !vaga.Disponivel) {
                    throw new Exception("Vaga não disponível.");
                }
                    

                vaga.Disponivel = false;
                _context.Reservas.Add(reserva);
                await _context.SaveChangesAsync();
                return reserva;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<ReservaModel>> GetReservasByUsuarioIdAsync(int usuarioId)
        {
            return await _context.Reservas
                   .Include(r => r.Vaga)
                   .Include(r => r.Carro)
                   .Where(r => r.UsuarioId == usuarioId)
                   .ToListAsync();
        }
    }
}
