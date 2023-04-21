using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;
using Commpay.Models.Enums;
using Commpay.Models;

namespace Commpay.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Expedidor> Expedidores { get; set; }

        public DbSet<Financeiro> Financeiros { get; set; }

        public DbSet<Vendedor> Vendedores { get; set; }

        public DbSet<Produto> Produtos { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>()
                .ToTable("Usuario")
                .HasDiscriminator(u => u.Cargo)
                .HasValue<Expedidor>(Cargos.Expedidor)
                .HasValue<Financeiro>(Cargos.Financeiro)
                .HasValue<Vendedor>(Cargos.Vendedor);
                
            modelBuilder.Entity<Usuario>()
                .Property(u => u.Cargo)
                .HasMaxLength(100);

        }

        public DbSet<Commpay.Models.Usuario>? Usuario { get; set; }
    }
}
