namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLEXPREMESSAITENSHIST")]
    public partial class WSQOLEXPREMESSAITENSHIST
    {
        public long ID { get; set; }

        public long? ID_REMESSA_ITENS { get; set; }

        public long? ID_REMESSA { get; set; }

        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        [StringLength(50)]
        public string UNIDADE_NEGOCIO { get; set; }

        [StringLength(50)]
        public string LOCAL_DEPOSITO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE { get; set; }

        [StringLength(50)]
        public string CODIGO_VENDA { get; set; }

        [StringLength(50)]
        public string ITEM_CODIGO_VENDA { get; set; }

        [StringLength(50)]
        public string NUMERO_SERIE { get; set; }

        [StringLength(50)]
        public string SITUACAO { get; set; }

        [StringLength(50)]
        public string ITEM_REMESSA { get; set; }

        public int? STATUS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_PICKING { get; set; }

        [StringLength(50)]
        public string DOCUMENTO_REFERENCIA { get; set; }

        [StringLength(50)]
        public string CATEGORIA_ITEM { get; set; }

        [StringLength(50)]
        public string DESC_CATEGORIA_ITEM { get; set; }

        [StringLength(50)]
        public string NR_ORDEM_V { get; set; }

        [StringLength(50)]
        public string NR_ITEM_ORDEM_V { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PESO_TOTAL { get; set; }

        [StringLength(50)]
        public string UNIDADE_PESO { get; set; }

        [StringLength(50)]
        public string USUARIO_ULTIMA_MOVIMENTACAO { get; set; }

        public DateTime? DATA_ULTIMA_MOVIMENTACAO { get; set; }

        [StringLength(250)]
        public string OBSERVACAO { get; set; }
    }
}
