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

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Vaga> Vagas { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
    }
}
