namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLRECEBIMENTODIVERGENCIAITENS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_DIVERGENCIA { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_PEDIDO_NF { get; set; }

        [StringLength(50)]
        public string CODIGO_RECEBIMENTO { get; set; }

        public int? TIPO_DIVERGENCIA { get; set; }

        public int? STATUS { get; set; }

        [StringLength(50)]
        public string USUARIO_CONFERENCIA { get; set; }

        [StringLength(50)]
        public string USUARIO_LANCAMENTO { get; set; }

        [StringLength(500)]
        public string OBSERVACAO { get; set; }

        [Key]
        [Column(Order = 2)]
        public long ID { get; set; }

        public int? CODIGO_JUSTIFICATIVA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_RECEBIDA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_TOTAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_RECEBIDA_TOTAL { get; set; }
    }
}
