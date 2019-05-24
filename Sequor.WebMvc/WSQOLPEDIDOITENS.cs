namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLPEDIDOITENS
    {
        public long ID { get; set; }

        public long? ID_PEDIDO { get; set; }

        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        [StringLength(50)]
        public string UNIDADE_NEGOCIO { get; set; }

        public DateTime? DATA_PREVISAO_ENTREGA { get; set; }

        [StringLength(50)]
        public string LOCAL_ENTREGA { get; set; }

        public int? STATUS_PEDIDO { get; set; }

        public DateTime? DATA_PREVISAO_ENTREGA_ATUAL { get; set; }

        public DateTime? DATA_EMBARQUE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_RECEBIDA { get; set; }

        [StringLength(50)]
        public string UNIDADE_MEDIDA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VALOR_UNITARIO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FATOR_VALOR { get; set; }

        [StringLength(50)]
        public string CATEGORIA_CUSTOS { get; set; }

        [StringLength(50)]
        public string CODIGO_INTERNO { get; set; }

        public int? CODIGO_INTERNO_ITEM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_VINCULADA { get; set; }

        public DateTime? DATA_INCLUSAO { get; set; }

        public DateTime? DATA_ULTIMA_MODIFICACAO { get; set; }

        [StringLength(50)]
        public string TIPO_ITEM { get; set; }

        [StringLength(50)]
        public string REMESSA_FINAL { get; set; }

        [StringLength(50)]
        public string CENTRO_CUSTOS { get; set; }

        public bool? MOVIMENTADO { get; set; }

        [StringLength(50)]
        public string DEPOSITO { get; set; }

        [StringLength(50)]
        public string PEDIDO_ITEM { get; set; }

        [StringLength(50)]
        public string TIPO_ESTOQUE { get; set; }
    }
}
