namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLINHAMONTAGEMREGRAS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string LINHA_MONTAGEM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ESTACAO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string REGRA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VALOR { get; set; }

        [StringLength(50)]
        public string ATRIBUTO { get; set; }

        [StringLength(4000)]
        public string ATRIBUTO_EX { get; set; }
    }
}
