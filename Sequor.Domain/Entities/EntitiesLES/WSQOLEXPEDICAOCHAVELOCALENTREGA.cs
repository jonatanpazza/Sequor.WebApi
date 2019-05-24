namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLEXPEDICAOCHAVELOCALENTREGA")]
    public partial class WSQOLEXPEDICAOCHAVELOCALENTREGA
    {
        public long ID { get; set; }

        public long ID_CHAVE { get; set; }

        public long ID_LOCAL { get; set; }

        [Required]
        [StringLength(50)]
        public string CODIGO_LOCAL { get; set; }
    }
}
