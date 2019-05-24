using Sequor.ApplicationService.LES.Interfaces.Cadastro;
using Sequor.Domain.Entities;
using Sequor.Domain.Entities.EntitiesLES;
using Sequor.Domain.Interfaces.Services.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequor.ApplicationService.Cadastro
{
    public class WSQOLRECEBIMENTOFOLHAROSTOAppService : AppServiceBase<WSQOLRECEBIMENTOFOLHAROSTO>, IWSQOLRECEBIMENTOFOLHAROSTOAppService
    {
        private readonly IWSQOLRECEBIMENTOFOLHAROSTOService _clienteService;

        public WSQOLRECEBIMENTOFOLHAROSTOAppService(IWSQOLRECEBIMENTOFOLHAROSTOService clienteService)
            : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<WSQOLRECEBIMENTOFOLHAROSTO> GetFolhaRostoInspecionadas()
        {
            return _clienteService.GetFolhaRostoInspecionadas();
        }
    }
}
