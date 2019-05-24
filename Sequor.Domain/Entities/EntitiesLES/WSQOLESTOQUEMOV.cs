namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLESTOQUEMOV")]
    public partial class WSQOLESTOQUEMOV
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string LOCAL { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string CODIGO_RASTREABILIDADE { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime DATA_MOVIMENTACAO { get; set; }

        [Key]
        [Column(Order = 4)]
        public long ID { get; set; }

        public int? ACAO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_LANCADA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_ATUAL { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        public int? STATUS_MOVIMENTACAO { get; set; }

        [StringLength(100)]
        public string MENSAGEM_STATUS_MOVIMENTACAO { get; set; }

        public long? ID_MOV_VINCULADA { get; set; }

        [StringLength(50)]
        public string ORIGEM_LANCAMENTO { get; set; }

        [StringLength(500)]
        public string INFO_ORIGEM_LANCAMENTO { get; set; }

        [StringLength(50)]
        public string INFO_ORIGEM_LANCAMENTO_2 { get; set; }

        [StringLength(500)]
        public string OBSERVACAO { get; set; }

        [StringLength(50)]
        public string VERSAO_MODULO_ULTIMA_MOVIMENTACAO { get; set; }

        [StringLength(50)]
        public string LOCAL_ORIGEM_MOV { get; set; }

        public int? NIVEL { get; set; }

        public long? ID_WSQOLESTOQUEATUAL { get; set; }

        [StringLength(50)]
        public string DOC_REFERENCIA { get; set; }

        [StringLength(50)]
        public string LOCAL_ORIGEM_DESTINO { get; set; }
    }
}
