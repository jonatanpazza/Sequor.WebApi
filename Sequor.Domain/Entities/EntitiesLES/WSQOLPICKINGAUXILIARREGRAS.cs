namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLPICKINGAUXILIARREGRAS
    {
        [Key]
        public int ID_PICKING_AUX_REGRAS { get; set; }

        public int? ID_PICKING_AUX { get; set; }

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
