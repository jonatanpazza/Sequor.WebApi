namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLQLCFOTO")]
    public partial class WSQOLQLCFOTO
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string MODULO { get; set; }

        [StringLength(50)]
        public string CHAVE { get; set; }

        [StringLength(50)]
        public string JUSTIFICATIVA { get; set; }

        [StringLength(500)]
        public string OBSERVACAO { get; set; }

        public int? STATUS { get; set; }
    }
}
