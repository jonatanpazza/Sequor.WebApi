namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLTIPOMOVIMENTOERPDEPOSITOCONFIG")]
    public partial class WSQOLTIPOMOVIMENTOERPDEPOSITOCONFIG
    {
        public long ID { get; set; }

        [Required]
        [StringLength(50)]
        public string TIPO_MOVIMENTO { get; set; }

        [Required]
        [StringLength(500)]
        public string DESCRICAO { get; set; }

        [Required]
        [StringLength(3)]
        public string CODIGO { get; set; }

        [Required]
        [StringLength(50)]
        public string DEPOSITO { get; set; }

        public bool HABILITADO { get; set; }
    }
}
