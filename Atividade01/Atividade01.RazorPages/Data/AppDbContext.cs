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
            modelBuilder.Entity<AtendimentoModel>().ToTable("Atendimentos").HasKey(e => e.AtendimentoID);
            modelBuilder.Entity<AtendimentoModel>().Property(e=>e.AtendimentoID).ValueGeneratedOnAdd();

            modelBuilder.Entity<CategoriaModel>().ToTable("Categorias").HasKey(j => j.CategoriaID);
            modelBuilder.Entity<CategoriaModel>().Property(p=>p.CategoriaID).ValueGeneratedOnAdd();

            modelBuilder.Entity<GarcomModel>().ToTable("Garcons").HasKey(j => j.GarcomID);
            modelBuilder.Entity<GarcomModel>().Property(p=>p.GarcomID).ValueGeneratedOnAdd();

            modelBuilder.Entity<MesaModel>().ToTable("Mesas").HasKey(j => j.MesaID);
            modelBuilder.Entity<MesaModel>().Property(p=>p.MesaID).ValueGeneratedOnAdd();

            modelBuilder.Entity<ProdutoModel>().ToTable("Mesas").HasKey(j => j.ProdutoID);
            modelBuilder.Entity<ProdutoModel>().Property(p=>p.ProdutoID).ValueGeneratedOnAdd();
        }
    }
}