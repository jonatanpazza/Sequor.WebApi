namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLINVENTARIOEQUIPEUSUARIO")]
    public partial class WSQOLINVENTARIOEQUIPEUSUARIO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string USUARIO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CODIGO_EQUIPE { get; set; }
    }
}
