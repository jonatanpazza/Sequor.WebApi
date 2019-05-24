namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLPICKINGAUXILIAR")]
    public partial class WSQOLPICKINGAUXILIAR
    {
        [Key]
        public long ID_PICKING_AUX { get; set; }

        [StringLength(50)]
        public string CHAVE { get; set; }

        [StringLength(50)]
        public string CODIGO_RASTREABILIDADE { get; set; }

        public DateTime? DATA_PROCESSO { get; set; }

        public long? ID_SEQ { get; set; }

        [StringLength(50)]
        public string KIT { get; set; }

        [StringLength(50)]
        public string GRUPO { get; set; }

        public int? SEQUENCIAMENTO { get; set; }

        public int? SEQUENCIAMENTO_ORIGINAL { get; set; }

        public int? STATUS { get; set; }

        [StringLength(50)]
        public string USUARIO_PICKING { get; set; }

        public DateTime? DATA_INCLUSAO { get; set; }

        public DateTime? DATA_ULTIMA_MOVIMENTACAO { get; set; }

        [StringLength(50)]
        public string PRIORIDADE_A { get; set; }

        [StringLength(50)]
        public string PRIORIDADE_B { get; set; }

        [StringLength(50)]
        public string PRIORIDADE_C { get; set; }

        [StringLength(10)]
        public string ORIGEM { get; set; }

        public long? ID_SEQ_ORIGEM { get; set; }

        [StringLength(50)]
        public string VERSAO_TABLET_ULTIMA_MOVIMENTACAO { get; set; }

        public bool? MSG_ENVIO_ERP_ENVIADA { get; set; }

        public long? ID_LANCAMENTOACAO { get; set; }

        [StringLength(100)]
        public string LOCAL_ENTREGA { get; set; }

        [StringLength(50)]
        public string CLIENTE { get; set; }

        [StringLength(100)]
        public string DESCRICAO_LOCAL_ENTREGA { get; set; }

        [StringLength(50)]
        public string DOC_REFERENCIA { get; set; }

        public long? ID_FALTANTE { get; set; }

        public long? ID_FALTANTE_OP_VINCULO { get; set; }

        [StringLength(50)]
        public string ITEM { get; set; }

        public long? ID_SEQ_ITENS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_PAGO { get; set; }

        public int? STATUS_ITEM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PESO { get; set; }

        [StringLength(50)]
        public string CODIGO_LEITURA { get; set; }

        [StringLength(50)]
        public string CODIGO_RASTREABILIDADE_ITEM { get; set; }

        public bool? INTEGRACAO_ERP { get; set; }

        [StringLength(50)]
        public string ID_ITEM_DOC { get; set; }

        [StringLength(50)]
        public string STATUS_ENVIO_ERP_CHAR { get; set; }
    }
}
