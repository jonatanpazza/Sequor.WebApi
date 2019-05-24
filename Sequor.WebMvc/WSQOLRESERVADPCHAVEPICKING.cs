namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLRESERVADPCHAVEPICKING")]
    public partial class WSQOLRESERVADPCHAVEPICKING
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
        public string TIPO_MOVIMENTO { get; set; }

        [StringLength(50)]
        public string CHAVE { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string NR_RESERVA { get; set; }
    }
}
