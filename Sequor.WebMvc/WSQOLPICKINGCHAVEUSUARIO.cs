namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLPICKINGCHAVEUSUARIO")]
    public partial class WSQOLPICKINGCHAVEUSUARIO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CHAVE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string USUARIO { get; set; }

        public bool? HABILITADO { get; set; }
    }
}
