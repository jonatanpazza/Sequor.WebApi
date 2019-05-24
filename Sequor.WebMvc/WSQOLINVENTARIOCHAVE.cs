namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLINVENTARIOCHAVE")]
    public partial class WSQOLINVENTARIOCHAVE
    {
        [Key]
        [StringLength(50)]
        public string CHAVE { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [StringLength(50)]
        public string DEPOSITO { get; set; }

        public int? CHAVE_LOCAL_MACRO { get; set; }
    }
}
