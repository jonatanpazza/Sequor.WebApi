namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLESTOQUEMOVERP")]
    public partial class WSQOLESTOQUEMOVERP
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        [StringLength(50)]
        public string NUMERO_DOCUMENTO { get; set; }

        public DateTime? DATA_MOVIMENTACAO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE { get; set; }

        [StringLength(1)]
        public string ACAO { get; set; }

        [StringLength(3)]
        public string TIPO_MOVIMENTO { get; set; }

        [StringLength(2)]
        public string STATUS { get; set; }

        [StringLength(50)]
        public string LOCAL_ERP { get; set; }

        [StringLength(50)]
        public string TRANSACAO { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        [StringLength(50)]
        public string UNIDADE_NEGOCIO { get; set; }

        [StringLength(50)]
        public string UNIDADE { get; set; }

        [StringLength(50)]
        public string FORNECEDOR { get; set; }

        [StringLength(50)]
        public string CLIENTE { get; set; }

        [StringLength(50)]
        public string CENTRO_CUSTO { get; set; }

        [StringLength(50)]
        public string ORDEM_CLIENTE { get; set; }

        public int? IT_ORDEM_CLIENTE { get; set; }

        [StringLength(50)]
        public string ORDEM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? SALDO_ESTOQUE_ANTERIOR { get; set; }

        public long? ID_MOV_ERP_VINCULADA { get; set; }

        [StringLength(50)]
        public string LOCAL_LES { get; set; }

        public long? ID_MOV_LES { get; set; }

        [StringLength(50)]
        public string LOTE_CONTROLE { get; set; }

        [StringLength(50)]
        public string ITEM_RECEBIMENTO { get; set; }

        [StringLength(50)]
        public string NUMERO_RECEBIMENTO { get; set; }

        [StringLength(50)]
        public string ITEM_PEDIDO { get; set; }

        [StringLength(50)]
        public string NUMERO_PEDIDO { get; set; }

        [StringLength(50)]
        public string DOC_MAT_ITEM { get; set; }

        [StringLength(50)]
        public string NUM_DOC_REF { get; set; }
    }
}
