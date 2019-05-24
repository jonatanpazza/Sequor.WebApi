namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLFORNECEDORPRODUTO")]
    public partial class WSQOLFORNECEDORPRODUTO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CODIGO_FORNECEDOR { get; set; }

        public int? LEADTIME { get; set; }

        public bool? FORNECEDOR_PREFERENCIAL { get; set; }

        public bool? BLOQUEAR_COMPRA { get; set; }

        public int? id_fornecedor { get; set; }
    }
}
