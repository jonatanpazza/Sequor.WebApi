using Sequor.Domain.Entities;
using Sequor.Domain.Entities.EntitiesLES;
using Sequor.Domain.Enumerables.EnumerablesLES;
using Sequor.Domain.Interfaces.Repositories.Cadastro;
using Sequor.Domain.Interfaces.Repositories.Recebimento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sequor.Infrastructure.Repositories
{
    public class WSQOLRECEBIMENTOFOLHAROSTORepository : RepositoryBase<WSQOLRECEBIMENTOFOLHAROSTO>, IWSQOLRECEBIMENTOFOLHAROSTORepository
    {
        //protected ProjetoModeloContext Db = new ProjetoModeloContext();

        //public IEnumerable<WSQOLRECEBIMENTOFOLHAROSTO> GetFolhaRostoAbertas()
        //{
        //    return Db.WSQOLRECEBIMENTOFOLHAROSTO.Where(p => p.STATUS != (int)STATUS_FOLHA_ROSTO.ITENS_INSPECIONADOS
        //                                                && p.STATUS != (int)STATUS_FOLHA_ROSTO.INSPECAO_ITENS_INICIADA
        //                                                && p.STATUS != (int)STATUS_FOLHA_ROSTO.FOLHA_ROSTO_EM_UTILIZACAO
        //                                                && p.STATUS != (int)STATUS_FOLHA_ROSTO.REMOVIDO_ERP
        //                                                && p.STATUS != (int)STATUS_FOLHA_ROSTO.ESTORNADO_ERP
        //                                                && p.STATUS != (int)STATUS_FOLHA_ROSTO.CANCELADA
        //                                                );
        //}

        public IEnumerable<WSQOLRECEBIMENTOFOLHAROSTO> GetFolhaRostoInspecionadas()
        {
            return Db.WSQOLRECEBIMENTOFOLHAROSTO.Where(p => p.STATUS == (int)STATUS_FOLHA_ROSTO.ITENS_INSPECIONADOS);
            //return Db.Set<WSQOLRECEBIMENTOFOLHAROSTO>().Where(p => p.STATUS == (int)STATUS_FOLHA_ROSTO.ITENS_INSPECIONADOS).ToList();
        }

        //public IEnumerable<WSQOLRECEBIMENTOFOLHAROSTO> GetFolhaRostoByStatus(STATUS_FOLHA_ROSTO statusFolhaRosto)
        //{
        //    return Db.WSQOLRECEBIMENTOFOLHAROSTO.Where(p => p.STATUS == (int)statusFolhaRosto);
        //}
    }
}