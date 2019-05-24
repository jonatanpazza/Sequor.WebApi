namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLPEDIDOMOVIMENTACAO")]
    public partial class WSQOLPEDIDOMOVIMENTACAO
    {
        [Key]
        public long ID_MOVIMENTACAO { get; set; }

        public long? ID_PEDIDO_ITEM { get; set; }

        public DateTime? DATA_OCORRENCIA { get; set; }

        public long? ID_PEDIDO { get; set; }

        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        [StringLength(50)]
        public string CODIGO_INTERNO { get; set; }

        public int? STATUS_PEDIDO { get; set; }

        public DateTime? DATA_PREVISAO_ENTREGA { get; set; }

        public DateTime? DATA_EMBARQUE { get; set; }

        public decimal? QUANTIDADE { get; set; }

        public decimal? QUANTIDADE_RECEBIDA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VALOR_UNITARIO { get; set; }

        public long? ID_NF { get; set; }

        [StringLength(50)]
        public string LOCAL_ENTREGA { get; set; }

        [StringLength(50)]
        public string CODIGO_JUSTIFICATIVA_VARIACAO { get; set; }

        [StringLength(200)]
        public string OBS { get; set; }

        public int? CODIGO_RECEBIMENTO { get; set; }

        public int? ID_CODIGO_FOLHA_ROSTO { get; set; }

        public bool? FOLHA_ROSTO_IMPRESSA { get; set; }

        public bool? ATUAL { get; set; }
    }
}
