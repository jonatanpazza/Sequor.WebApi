namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLPICKINGAUXILIARSTATUS
    {
        [Key]
        public int ID_PICKING_AUX_STATUS { get; set; }

        public int? ID_PICKING_AUX { get; set; }

        public int? STATUS { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        public DateTime? DATA_OCORRENCIA { get; set; }

        [StringLength(500)]
        public string MESSAGE { get; set; }

        public int? ACTION { get; set; }

        public int? MODULO { get; set; }
    }
}
