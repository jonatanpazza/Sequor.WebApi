namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLOGINSREGRAS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string USUARIO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string REGRA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VALOR { get; set; }

        [StringLength(50)]
        public string ATRIBUTO { get; set; }

        [StringLength(4000)]
        public string ATRIBUTO_EX { get; set; }
    }
}
