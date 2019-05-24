namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLINHAMONTAGEMAGRUPAMENTO")]
    public partial class WSQOLINHAMONTAGEMAGRUPAMENTO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string GRUPO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string LINHA_MONTAGEM { get; set; }
    }
}
