namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLVEICULOSTRANSPORTE")]
    public partial class WSQOLVEICULOSTRANSPORTE
    {
        [Key]
        [StringLength(50)]
        public string CODIGO_VEICULO { get; set; }

        [StringLength(200)]
        public string DESCRICAO { get; set; }
    }
}
