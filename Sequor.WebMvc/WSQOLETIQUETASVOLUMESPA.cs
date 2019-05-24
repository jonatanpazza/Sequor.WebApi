namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLETIQUETASVOLUMESPA")]
    public partial class WSQOLETIQUETASVOLUMESPA
    {
        [Required]
        [StringLength(50)]
        public string CODIGO_VOLUME { get; set; }

        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        [StringLength(50)]
        public string OPERACAO { get; set; }

        public int? SEQUENCIA_IMPRESSAO { get; set; }

        [StringLength(50)]
        public string DESCRICAO_VOLUME { get; set; }

        public int? QUANTIDADE_IMPRESSAO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PESO_EMBALAGEM_KG { get; set; }

        public long ID { get; set; }
    }
}
