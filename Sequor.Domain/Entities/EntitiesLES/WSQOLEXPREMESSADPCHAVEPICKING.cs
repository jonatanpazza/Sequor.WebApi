namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLEXPREMESSADPCHAVEPICKING")]
    public partial class WSQOLEXPREMESSADPCHAVEPICKING
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string UNIDADE_NEGOCIO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string DEPOSITO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string CODIGO_MOTIVO { get; set; }

        [StringLength(50)]
        public string CHAVE_PICKING { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string CODIGO_CLIENTE { get; set; }

        [StringLength(50)]
        public string DATA_PROCESSO_REGRA { get; set; }
    }
}
