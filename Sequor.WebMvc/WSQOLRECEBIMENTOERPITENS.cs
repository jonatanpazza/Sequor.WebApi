namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLRECEBIMENTOERPITENS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_RECEBIMENTO { get; set; }

        [Key]
        [Column(Order = 1)]
        public long ID { get; set; }

        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE { get; set; }

        [StringLength(50)]
        public string UNIDADE_MEDIDA { get; set; }

        [StringLength(50)]
        public string ITEM_REMESSA { get; set; }

        [StringLength(50)]
        public string DEPOSITO { get; set; }

        [StringLength(50)]
        public string PEDIDO { get; set; }

        [StringLength(50)]
        public string CODIGO_FORNECEDOR { get; set; }

        [StringLength(50)]
        public string COMPRADOR { get; set; }

        [StringLength(50)]
        public string SNUMERO_NF { get; set; }

        public int? NUMERO_NF { get; set; }

        [StringLength(50)]
        public string CENTRO_CUSTOS { get; set; }

        [StringLength(50)]
        public string REQUISITANTE { get; set; }

        public bool? VINCULADO_PEDIDO_ITEM { get; set; }

        public bool? VINCULADO_NF { get; set; }

        public DateTime? DATA_INCLUSAO { get; set; }

        public bool? ENTRADA_ESTOQUE_ERP { get; set; }

        [StringLength(50)]
        public string ITEM_PEDIDO { get; set; }

        [StringLength(50)]
        public string CATEGORIA_CUSTOS { get; set; }

        [StringLength(50)]
        public string TIPO_ESTOQUE { get; set; }
    }
}
