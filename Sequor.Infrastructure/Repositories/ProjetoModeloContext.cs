using Sequor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequor.Infrastructure.Repositories
{
    public class ProjetoModeloContext : DbContext
    {
        public ProjetoModeloContext()
            : base("StaraContext")
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
        //public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
