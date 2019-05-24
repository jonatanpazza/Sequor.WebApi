namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLPICKINGSEQITEMEMBALAGEMHIST")]
    public partial class WSQOLPICKINGSEQITEMEMBALAGEMHIST
    {
        [Key]
        [Column(Order = 0)]
        public long ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_EMBALAGEM { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string LOCAL { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(200)]
        public string DESCRICAO { get; set; }

        [Key]
        [Column(Order = 4)]
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
