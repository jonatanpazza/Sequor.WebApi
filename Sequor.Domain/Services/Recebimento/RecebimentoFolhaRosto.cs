using Sequor.Domain.Interfaces.Repositories.Cadastro;
using Sequor.Domain.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequor.Domain.Services.Recebimento
{
    public class RecebimentoFolhaRosto
    {
        private readonly IClienteRepository _clienteRepository;
        // private readonly IWSQORECEBIMENTOFOLHAROSTORepository _WSQORECEBIMENTOFOLHAROSTORepository;
        // private readonly IWSQORECEBIMENTOFOLHAROSTOHISTRepository _WSQORECEBIMENTOFOLHAROSTOHISTRepository;

        #region Métodos Publicos

        public RecebimentoFolhaRostoViewModel CriarFolhaRosto(RecebimentoFolhaRostoViewModel folhaRostoViewModel)
        {
            // 1ª - Insert na tabela WSQORECEBIMENTOFOLHAROSTO

            //_clienteRepository.Add(folhaRostoViewModel.FolhaRosto);
            // folhaRostoViewModel.FolhaRosto = _WSQORECEBIMENTOFOLHAROSTOHISTRepository.Add(folhaRostoViewModel.FolhaRosto);

            // 2ª - insert na tabela WSQORECEBIMENTOFOLHAROSTOHIST

            return folhaRostoViewModel;
        }

        #endregion

    }
}
