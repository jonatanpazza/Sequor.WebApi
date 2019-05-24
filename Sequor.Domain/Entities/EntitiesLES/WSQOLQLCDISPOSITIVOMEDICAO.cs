namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLQLCDISPOSITIVOMEDICAO")]
    public partial class WSQOLQLCDISPOSITIVOMEDICAO
    {
        [Key]
        public int ID_DISPOSITIVO { get; set; }

        [StringLength(100)]
        public string DISPOSITIVO { get; set; }
    }
}
