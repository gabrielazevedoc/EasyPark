using EasyParkAPI.Infrastructure;
using EasyParkAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace EasyParkAPI.Services.Carro
{
    public class CarroService : ICarroService
    {

        private readonly ConnectionContext _context;

        public CarroService(ConnectionContext context)
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
