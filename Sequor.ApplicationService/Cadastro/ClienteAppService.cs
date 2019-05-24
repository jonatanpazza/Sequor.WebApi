using Sequor.ApplicationService.LES.Interfaces.Cadastro;
using Sequor.Domain.Entities;
using Sequor.Domain.Interfaces.Services.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequor.ApplicationService.Cadastro
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
            : base(clienteService)
        {
            _clienteService = clienteService;
        }

        //public IEnumerable<Cliente> ObterClientesEspeciais()
        //{
        //    return _clienteService.ObterClientesEspeciais(_clienteService.GetAll());
        //}
    }
}
