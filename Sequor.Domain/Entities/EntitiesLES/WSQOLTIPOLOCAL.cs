namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLTIPOLOCAL")]
    public partial class WSQOLTIPOLOCAL
    {
        [Key]
        public long ID_TIPO_LOCAL { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }
    }
}
