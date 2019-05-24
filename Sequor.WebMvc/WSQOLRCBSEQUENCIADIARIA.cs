namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLRCBSEQUENCIADIARIA")]
    public partial class WSQOLRCBSEQUENCIADIARIA
    {
        public DateTime? DATA_SEQUENCIA { get; set; }

        [Key]
        public int SEQUENCIA { get; set; }
    }
}
