namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLPEDIDOTIPO")]
    public partial class WSQOLPEDIDOTIPO
    {
        [Key]
        [StringLength(50)]
        public string CODIGO { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [StringLength(50)]
        public string PRIORIDADE_A_PICKING { get; set; }
    }
}
