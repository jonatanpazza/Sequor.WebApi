namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLOGINSPERFIS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string USUARIO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string PERFIL { get; set; }
    }
}
