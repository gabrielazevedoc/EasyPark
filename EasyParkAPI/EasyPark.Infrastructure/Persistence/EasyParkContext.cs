using EasyPark.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyPark.Infrastructure.Persistence
{
    public class EasyParkContext : DbContext
    {

        public EasyParkContext(DbContextOptions<EasyParkContext> options)
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
                .HasKey(u => u.Id);

            modelBuilder.Entity<UsuarioModel>()
                .HasMany(u => u.Carros);

            modelBuilder.Entity<UsuarioModel>()
                .HasMany(u => u.Reservas);

            modelBuilder.Entity<VagaModel>()
                .HasMany(v => v.Reservas)
                .WithOne(r => r.Vaga)
                .HasForeignKey(r => r.VagaId);
        }
    }
}
