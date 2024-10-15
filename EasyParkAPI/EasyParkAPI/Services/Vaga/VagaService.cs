using EasyParkAPI.Infrastructure;
using EasyParkAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;

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
