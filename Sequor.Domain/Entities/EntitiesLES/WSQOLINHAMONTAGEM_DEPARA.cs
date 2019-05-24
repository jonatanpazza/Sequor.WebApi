namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLINHAMONTAGEM_DEPARA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string LINHA_MONTAGEM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ESTACAO { get; set; }

        [StringLength(50)]
        public string LINHA_MONTAGEM_DEPARA { get; set; }

        [StringLength(50)]
        public string ESTACAO_DEPARA { get; set; }
    }
}
