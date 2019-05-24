namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLQLCTIPOVALIDACAOPLANO")]
    public partial class WSQOLQLCTIPOVALIDACAOPLANO
    {
        [Key]
        public int ID_VALIDACAO_PLANO { get; set; }

        [StringLength(50)]
        public string DESCRICAO { get; set; }
    }
}
