namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLMODULOS
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string MODULO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string SUBMODULO { get; set; }
    }
}
