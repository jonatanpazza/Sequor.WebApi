namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLINVENTARIOCHAVELOCAL")]
    public partial class WSQOLINVENTARIOCHAVELOCAL
    {
        [Required]
        [StringLength(50)]
        public string CHAVE { get; set; }

        [Key]
        [StringLength(50)]
        public string CODIGO_LOCAL { get; set; }
    }
}
