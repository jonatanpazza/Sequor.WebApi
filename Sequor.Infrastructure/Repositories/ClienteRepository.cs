using Sequor.Domain.Entities;
using Sequor.Domain.Interfaces.Repositories.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sequor.Infrastructure.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        //public IEnumerable<Cliente> BuscarPorNome(string nome)
        //{
        //    return Db.Clientes.Where(p => p.Nome == nome);
        //}
    }
}