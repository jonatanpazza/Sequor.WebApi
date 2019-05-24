using Sequor.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequor.Domain.ViewModel
{
    public class RecebimentoFolhaRostoViewModel
    { 
        public Cliente FolhaRosto { get; set; }

        public List<Cliente> FolhaRostoHist { get; set; }

    }
}
