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
            : base("Sequor")
        {

        }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
