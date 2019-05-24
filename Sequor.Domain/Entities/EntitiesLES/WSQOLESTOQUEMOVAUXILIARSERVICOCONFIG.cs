namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLESTOQUEMOVAUXILIARSERVICOCONFIG")]
    public partial class WSQOLESTOQUEMOVAUXILIARSERVICOCONFIG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO_SERVICO { get; set; }

        public bool HABILITADO { get; set; }
    }
}
