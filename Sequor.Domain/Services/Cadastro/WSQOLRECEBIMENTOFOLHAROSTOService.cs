using Sequor.Domain;
using Sequor.Domain.Entities;
using Sequor.Domain.Interfaces.Repositories.Cadastro;
using Sequor.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sequor.Domain.Interfaces.Services.Cadastro;
using Sequor.Domain.Entities.EntitiesLES;
using Sequor.Domain.Interfaces.Repositories.Recebimento;

namespace Sequor.Domain.Services.Cadastro
{
    public class WSQOLRECEBIMENTOFOLHAROSTOService : ServiceBase<WSQOLRECEBIMENTOFOLHAROSTO>, IWSQOLRECEBIMENTOFOLHAROSTOService
    {
        private readonly IWSQOLRECEBIMENTOFOLHAROSTORepository _WSQOLRECEBIMENTOFOLHAROSTORepository;

        public WSQOLRECEBIMENTOFOLHAROSTOService(IWSQOLRECEBIMENTOFOLHAROSTORepository WSQOLRECEBIMENTOFOLHAROSTORepository)
            : base(WSQOLRECEBIMENTOFOLHAROSTORepository)
        {
            _WSQOLRECEBIMENTOFOLHAROSTORepository = WSQOLRECEBIMENTOFOLHAROSTORepository;
        }

        public IEnumerable<WSQOLRECEBIMENTOFOLHAROSTO> GetFolhaRostoInspecionadas()
        {
            return _WSQOLRECEBIMENTOFOLHAROSTORepository.GetFolhaRostoInspecionadas();
        }
        //public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
        //{
        //    return clientes.Where(c => c.ClienteEspecial(c));
        //}
    }
}
