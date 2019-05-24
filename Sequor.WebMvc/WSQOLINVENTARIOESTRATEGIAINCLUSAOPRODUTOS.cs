namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLINVENTARIOESTRATEGIAINCLUSAOPRODUTOS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        [StringLength(50)]
        public string STORED_PROCEDURE { get; set; }

        [StringLength(50)]
        public string DESCRICAO { get; set; }
    }
}
