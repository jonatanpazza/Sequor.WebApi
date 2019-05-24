namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLPICKINGSEQITEMEMBALAGEMEXTENSOES
    {
        public long ID { get; set; }

        public long? ID_EMBALAGEM { get; set; }

        [StringLength(200)]
        public string DESCRICAO { get; set; }

        public long? TIPO_EMBALAGEM { get; set; }

        public long? ID_PICKING_SEQ { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ALTURA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LARGURA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? COMPRIMENTO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PESO_TOTAL_VOLUME { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PESO_TOTAL_CALCULADO { get; set; }

        [StringLength(50)]
        public string CODIGO_RASTREABILIDADE_VOLUME { get; set; }

        [StringLength(50)]
        public string USUARIO_ULTIMA_MOVIMENTACAO { get; set; }

        public DateTime? DATA_ULTIMA_MOVIMENTACAO { get; set; }
    }
}
