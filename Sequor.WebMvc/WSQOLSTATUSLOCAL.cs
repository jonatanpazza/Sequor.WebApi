namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLSTATUSLOCAL")]
    public partial class WSQOLSTATUSLOCAL
    {
        [Key]
        public long ID_STATUS_LOCAL { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }
    }
}
