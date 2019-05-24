namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLRECEBIMENTOERP")]
    public partial class WSQOLRECEBIMENTOERP
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CODIGO_RECEBIMENTO { get; set; }

        [StringLength(1)]
        public string DIRECAO { get; set; }

        [Key]
        [Column(Order = 1)]
        public long ID { get; set; }

        public DateTime? DATA_INCLUSAO { get; set; }
    }
}
