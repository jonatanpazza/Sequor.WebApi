namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLPICKINGSEQITEMEMBALAGEM")]
    public partial class WSQOLPICKINGSEQITEMEMBALAGEM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Key]
        [StringLength(50)]
        public string LOCAL { get; set; }

        [Required]
        [StringLength(200)]
        public string DESCRICAO { get; set; }

        public bool EMBALAGEM { get; set; }

        public long? TIPO_EMBALAGEM { get; set; }

        public long? ID_PICKING_SEQ { get; set; }

        public long? ID_PICKING_SEQ_ITEM { get; set; }

        public int? QTD_EXTENSOES { get; set; }

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
        public string USUARIO_ULTIMA_MOVIMENTACAO { get; set; }

        public DateTime? DATA_ULTIMA_MOVIMENTACAO { get; set; }
    }
}
