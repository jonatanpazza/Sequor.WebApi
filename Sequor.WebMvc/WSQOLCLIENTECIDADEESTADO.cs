namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLCLIENTECIDADEESTADO")]
    public partial class WSQOLCLIENTECIDADEESTADO
    {
        [Key]
        [StringLength(50)]
        public string CODIGO_CLIENTE { get; set; }

        [Required]
        [StringLength(10)]
        public string PAIS { get; set; }

        [Required]
        [StringLength(10)]
        public string REGIAO { get; set; }

        [Required]
        [StringLength(500)]
        public string LOCAL { get; set; }
    }
}
