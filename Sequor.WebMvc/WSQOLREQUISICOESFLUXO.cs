namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLREQUISICOESFLUXO")]
    public partial class WSQOLREQUISICOESFLUXO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CODIGO_REQUISICAO { get; set; }

        [Key]
        [Column(Order = 1)]
        public long ID { get; set; }

        public DateTime? DATA_LANCAMENTO { get; set; }

        [StringLength(50)]
        public string SETOR_LANCAMENTO { get; set; }

        [StringLength(50)]
        public string SETOR_ENVIADO { get; set; }

        public int? STATUS { get; set; }

        [StringLength(50)]
        public string WORKFLOW_UTILIZADO { get; set; }

        public bool? ESTORNADO { get; set; }

        [StringLength(500)]
        public string OBSERVACAO { get; set; }
    }
}
