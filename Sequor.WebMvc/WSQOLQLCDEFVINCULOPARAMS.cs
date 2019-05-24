namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLQLCDEFVINCULOPARAMS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_VINCULO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string PARAMETRO { get; set; }

        public int? TIPO_DADO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VALOR { get; set; }

        [StringLength(50)]
        public string ATRIBUTO { get; set; }
    }
}
