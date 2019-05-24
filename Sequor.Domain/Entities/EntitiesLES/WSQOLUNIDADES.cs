namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLUNIDADES
    {
        [Key]
        [StringLength(50)]
        public string CODIGO_UNIDADE { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID_UNIDADE { get; set; }

        [Required]
        [StringLength(100)]
        public string DESCRICAO { get; set; }
    }
}
