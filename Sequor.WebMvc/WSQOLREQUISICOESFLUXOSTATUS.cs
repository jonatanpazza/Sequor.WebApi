namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLREQUISICOESFLUXOSTATUS
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string DESCRICAO { get; set; }
    }
}
