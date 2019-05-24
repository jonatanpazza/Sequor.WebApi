namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLQLCMODULO")]
    public partial class WSQOLQLCMODULO
    {
        [Key]
        [StringLength(50)]
        public string MODULO { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }
    }
}
