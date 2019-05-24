namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLEXPEDICAOESTOQUEORDEMVENDASAP")]
    public partial class WSQOLEXPEDICAOESTOQUEORDEMVENDASAP
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string MATERIAL { get; set; }

        [StringLength(50)]
        public string DEPOSITO { get; set; }

        [StringLength(50)]
        public string ORDEM_VENDA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ITEM_ORDEM_VENDA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE { get; set; }

        public bool? ESTOQUE_VINCULADO { get; set; }

        [StringLength(500)]
        public string OBSERVACAO { get; set; }
    }
}
