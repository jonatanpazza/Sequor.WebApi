namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLTIPORECIPIENTE")]
    public partial class WSQOLTIPORECIPIENTE
    {
        [Key]
        public long ID_TIPO_RECIPIENTE { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ALTURA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LARGURA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? COMPRIMENTO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PESO_MAXIMO { get; set; }

        [StringLength(50)]
        public string MODULO { get; set; }

        [StringLength(50)]
        public string GRUPO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PESO_RECIPIENTE { get; set; }
    }
}
