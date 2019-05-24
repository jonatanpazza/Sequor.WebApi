namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLPICKINGGRUPOKIT")]
    public partial class WSQOLPICKINGGRUPOKIT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CHAVE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string GRUPO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string KIT { get; set; }

        [StringLength(50)]
        public string GRUPO_DESCRICAO { get; set; }
    }
}
