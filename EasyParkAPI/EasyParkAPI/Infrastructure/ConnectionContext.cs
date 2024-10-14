using EasyParkAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace EasyParkAPI.Infrastructure
{
    public class ConnectionContext : DbContext
    {

        public ConnectionContext(DbContextOptions<ConnectionContext> options)
            : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<CarroModel> Carros { get; set; }
        public DbSet<VagaModel> Vagas { get; set; }
        public DbSet<ReservaModel> Reservas { get; set; }
    }
}
