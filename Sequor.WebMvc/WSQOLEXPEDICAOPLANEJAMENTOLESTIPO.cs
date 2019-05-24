namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLEXPEDICAOPLANEJAMENTOLESTIPO")]
    public partial class WSQOLEXPEDICAOPLANEJAMENTOLESTIPO
    {
        public long ID { get; set; }

        public int? TIPO { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }
    }
}
