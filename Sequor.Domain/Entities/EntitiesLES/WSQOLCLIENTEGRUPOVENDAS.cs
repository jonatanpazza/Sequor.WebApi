namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLCLIENTEGRUPOVENDAS
    {
        [Key]
        [StringLength(50)]
        public string CODIGO { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }
    }
}
