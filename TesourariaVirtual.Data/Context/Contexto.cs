using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TesourariaVirtual.Domain.Entities;

namespace TesourariaVirtual.Data.Context
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<Gasto> Gasto { get; set; }

        public DbSet<Renda> Renda { get; set; }

        public DbSet<Carteira> Carteira { get; set; }

        public DbSet<TipoGasto> TipoGasto { get; set; }

        public DbSet<TipoRenda> TipoRenda { get; set; }

        public DbSet<ConfiguracaoGeral> ConfiguracaoGeral { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //        optionsBuilder.UseSqlServer(GetConnectionString());
        //}

        //protected override void OnModelCreating(ModelBuilder model)
        //{
        //    model.Entity<Renda>().ToTable("Renda");
        //}

        private string GetConnectionString()
        {
            return @"Server=(localdb)\mssqllocaldb;Database=Blogging;Integrated Security=True";
        }


    }
}
