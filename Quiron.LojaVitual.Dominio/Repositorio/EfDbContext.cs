using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using Quiron.LojaVitual.Dominio.Entidade;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Quiron.LojaVitual.Dominio.Repositorio
{
   public class EfDbContext : DbContext{
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produtos");
        }

    }
}
