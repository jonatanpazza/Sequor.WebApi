namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLQLCVALIDACAO")]
    public partial class WSQOLQLCVALIDACAO
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string ESQUEMA { get; set; }

        [StringLength(500)]
        public string DESCRICAO { get; set; }

        [StringLength(50)]
        public string MODULO { get; set; }

        public bool? DINAMICA { get; set; }
    }
}
