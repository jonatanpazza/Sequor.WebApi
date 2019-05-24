namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLREQUISICOESITENS
    {
        public long ID_REQUISICAO { get; set; }

        [Required]
        [StringLength(50)]
        public string CODIGO_ITEM { get; set; }

        public int TIPO_ITEM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE { get; set; }

        [StringLength(500)]
        public string OBSERVACAO { get; set; }

        public bool? REQUISICAO_FALTANTE { get; set; }

        [StringLength(50)]
        public string CODIGO_RASTREABILIDADE { get; set; }

        public long ID { get; set; }
    }
}
