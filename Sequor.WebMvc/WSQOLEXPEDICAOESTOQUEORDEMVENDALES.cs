namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLEXPEDICAOESTOQUEORDEMVENDALES
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string LOCAL_ORIGEM_MOV { get; set; }

        [StringLength(50)]
        public string LOCAL { get; set; }

        [StringLength(50)]
        public string DEPOSITO { get; set; }

        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE { get; set; }

        [StringLength(50)]
        public string CODIGO_RASTREABILIDADE { get; set; }

        [StringLength(50)]
        public string ORDEM_VENDA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ITEM_ORDEM_VENDA { get; set; }

        public DateTime? DATA_PRIMEIRA_MOVIMENTACAO { get; set; }

        public Guid? GUID { get; set; }

        public bool? ESTOQUE_VINCULADO { get; set; }

        [StringLength(500)]
        public string OBSERVACAO { get; set; }
    }
}
