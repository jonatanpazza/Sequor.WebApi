namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLKANBANCLIENTESGRUPO")]
    public partial class WSQOLKANBANCLIENTESGRUPO
    {
        [Key]
        public long ID_GRUPO { get; set; }

        [Required]
        [StringLength(50)]
        public string GRUPO { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRICAO { get; set; }
    }
}
