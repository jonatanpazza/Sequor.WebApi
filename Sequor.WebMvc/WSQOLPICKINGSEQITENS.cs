namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLPICKINGSEQITENS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_SEQ { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ITEM { get; set; }

        [Key]
        [Column(Order = 2)]
        public long ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_PAGO { get; set; }

        public int? STATUS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PESO { get; set; }

        [StringLength(50)]
        public string CODIGO_LEITURA { get; set; }

        [StringLength(50)]
        public string CODIGO_RASTREABILIDADE { get; set; }

        public bool? INTEGRACAO_ERP { get; set; }

        [StringLength(50)]
        public string ID_ITEM_DOC { get; set; }

        public int? POSSUI_SALDO_ESTOQUE { get; set; }

        public int? SALDO_ESTOQUE_DISPONIVEL { get; set; }

        public DateTime? DATA_ULTIMA_ANALISE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_FALTANTE { get; set; }
    }
}
