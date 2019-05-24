namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLCENTROCUSTO")]
    public partial class WSQOLCENTROCUSTO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string UNIDADE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CODIGO_CCT { get; set; }

        [StringLength(100)]
        public string DESCRICAO_CCT { get; set; }
    }
}
