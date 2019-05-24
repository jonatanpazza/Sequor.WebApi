namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLIMPRESSORASLOCAIS
    {
        [Key]
        public int ID_PRINT { get; set; }

        [StringLength(50)]
        public string IMPRESSORA { get; set; }

        [StringLength(500)]
        public string DESCRICAO { get; set; }
    }
}
