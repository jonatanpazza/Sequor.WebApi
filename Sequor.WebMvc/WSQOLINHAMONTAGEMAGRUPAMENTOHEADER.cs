namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLINHAMONTAGEMAGRUPAMENTOHEADER")]
    public partial class WSQOLINHAMONTAGEMAGRUPAMENTOHEADER
    {
        [Key]
        [StringLength(50)]
        public string GRUPO { get; set; }

        [StringLength(100)]
        public string DESCRICAO_GRUPO { get; set; }

        public bool? PROCESSO { get; set; }

        public bool? ESTATISTICA { get; set; }
    }
}
