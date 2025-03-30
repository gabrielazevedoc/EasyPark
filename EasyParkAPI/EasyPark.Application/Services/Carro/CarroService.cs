using EasyPark.Core.Entities;
using EasyPark.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;


namespace EasyPark.Application.Services.Carro
{
    public class CarroService : ICarroService
    {

        private readonly EasyParkContext _context;

        public CarroService(EasyParkContext context)
        {
            _context = context;
        }
        public async Task<CarroModel> AddCarroAsync(CarroModel carro)
        {
            _context.Carros.Add(carro);
            await _context.SaveChangesAsync();
            return carro;
        }

        public async Task<IEnumerable<CarroModel>> GetCarrosByUsuarioIdAsync(int usuarioId)
        {
            return await _context.Carros
            .Where(c => c.UsuarioId == usuarioId)
            .ToListAsync();
        }
    }
}
