namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLUNIDADESMEDIDA")]
    public partial class WSQOLUNIDADESMEDIDA
    {
        [Key]
        [StringLength(50)]
        public string COD_UNIDADE_MEDIDA { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TOLERANCIA { get; set; }

        public bool? ACEITA_VALORES_FRACIONADOS { get; set; }
    }
}
