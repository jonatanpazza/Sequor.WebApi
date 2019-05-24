using Sequor.ApplicationService.LES.Interfaces;
using Sequor.Domain.Entities;
using Sequor.Domain.Entities.EntitiesLES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequor.ApplicationService.LES.Interfaces.Cadastro
{
    public interface IWSQOLRECEBIMENTOFOLHAROSTOAppService : IAppServiceBase<WSQOLRECEBIMENTOFOLHAROSTO>
    {
        IEnumerable<WSQOLRECEBIMENTOFOLHAROSTO> GetFolhaRostoInspecionadas();
    }
}
