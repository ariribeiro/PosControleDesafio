using Microsoft.EntityFrameworkCore;
using PosControleDesafio.Domain.Models;
using System;
using System.Linq;

namespace PosControleDesafio.Infra.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }
        
        public DbSet<Usuario> Usuarios {  get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasSequence<int>("seq_Categoria")
                .StartsAt(0)
                .IncrementsBy(1);

            modelBuilder.Entity<Categoria>()
                .Property(o => o.Id)
                .HasDefaultValueSql("NEXT VALUE FOR seq_Categoria");

            
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }


            }

            return base.SaveChanges();
        }
    }
}
