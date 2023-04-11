using Atividade01.RazorPages.Models;
using Microsoft.EntityFrameworkCore;

namespace Atividade01.RazorPages.Data {
    public class AppDbContext : DbContext
    {
        public DbSet<AtendimentoModel>? Atendimentos { get; set; }
        public DbSet<CategoriaModel>? Categorias { get; set; }
        public DbSet<GarcomModel>? Garcons { get; set; }
        public DbSet<MesaModel>? Mesas { get; set; }
        public DbSet<ProdutoModel>? Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=tds.db;Cache=Shared");

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<AtendimentoModel>().ToTable("Eventos");
            modelBuilder.Entity<AtendimentoModel>().ToTable("Eventos");
            modelBuilder.Entity<AtendimentoModel>().ToTable("Eventos");
            modelBuilder.Entity<AtendimentoModel>().ToTable("Eventos");
            modelBuilder.Entity<AtendimentoModel>().ToTable("Eventos");
            
        }
    }
}