using Microsoft.EntityFrameworkCore;
using ProjetoBestProject.Infra.Data.Entities;
using ProjetoBestProject.Infra.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoBestProject.Infra.Data.Contexts
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //adicionar cada classe de mapeamento
            modelBuilder.ApplyConfiguration(new ContatoMap());
        }

        public DbSet<Contato> Contato { get; set; }
    }
}
