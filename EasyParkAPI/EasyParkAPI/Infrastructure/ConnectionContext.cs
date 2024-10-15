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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Definindo relacionamentos
            modelBuilder.Entity<UsuarioModel>()
                .HasMany(u => u.Carros)
                .WithOne(c => c.Usuario)
                .HasForeignKey(c => c.UsuarioId);

            modelBuilder.Entity<UsuarioModel>()
                .HasMany(u => u.Reservas)
                .WithOne(r => r.Usuario)
                .HasForeignKey(r => r.UsuarioId);

            modelBuilder.Entity<VagaModel>()
                .HasMany(v => v.Reservas)
                .WithOne(r => r.Vaga)
                .HasForeignKey(r => r.VagaId);
        }
    }
}
