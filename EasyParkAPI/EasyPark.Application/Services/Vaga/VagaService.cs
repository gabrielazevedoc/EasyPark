using EasyPark.Application.Services.Vaga;
using EasyPark.Core.Entities;
using EasyPark.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace EasyParkAPI.Services.Vaga
{
    public class VagaService : IVagaService
    {
        private readonly ConnectionContext _context;

        public VagaService(ConnectionContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<VagaModel>> GetVagasAsync()
        {
            return await _context.Vagas.ToListAsync();
        }
    }
}
