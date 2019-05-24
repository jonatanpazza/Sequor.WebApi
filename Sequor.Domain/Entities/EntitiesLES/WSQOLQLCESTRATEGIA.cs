namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLQLCESTRATEGIA")]
    public partial class WSQOLQLCESTRATEGIA
    {
        [Key]
        [StringLength(50)]
        public string ESTRATEGIA { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "xml")]
        public string CAMPOS { get; set; }

        [StringLength(50)]
        public string TEMPLATE_SEGREGACAO { get; set; }

        [StringLength(50)]
        public string TEMPLATE_GRAVACAO_DADOS { get; set; }

        public bool? PERMITE_MULTIPLOS { get; set; }

        public int? ORDEM { get; set; }
    }
}
