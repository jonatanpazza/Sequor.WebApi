namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLKANBANCLIENTES
    {
        [Key]
        public long ID_CLIENTE { get; set; }

        [Required]
        [StringLength(50)]
        public string CLIENTE { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRICAO { get; set; }

        public long ID_GRUPO { get; set; }
    }
}
