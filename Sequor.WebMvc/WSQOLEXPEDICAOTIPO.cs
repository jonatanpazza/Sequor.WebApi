namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLEXPEDICAOTIPO")]
    public partial class WSQOLEXPEDICAOTIPO
    {
        public long ID { get; set; }

        [Required]
        [StringLength(50)]
        public string CODIGO { get; set; }

        [Required]
        [StringLength(250)]
        public string DESCRICAO { get; set; }
    }
}
