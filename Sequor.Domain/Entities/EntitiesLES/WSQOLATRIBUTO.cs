namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLATRIBUTO")]
    public partial class WSQOLATRIBUTO
    {
        [Key]
        public long ID_ATRIBUTO { get; set; }

        [Required]
        [StringLength(50)]
        public string ATRIBUTO { get; set; }
    }
}
