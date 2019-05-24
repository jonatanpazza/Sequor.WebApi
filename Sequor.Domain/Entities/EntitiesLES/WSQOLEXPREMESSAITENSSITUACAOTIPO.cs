namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLEXPREMESSAITENSSITUACAOTIPO")]
    public partial class WSQOLEXPREMESSAITENSSITUACAOTIPO
    {
        [Key]
        [Column(Order = 0)]
        public long ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string SITUACAO { get; set; }

        [StringLength(50)]
        public string DESC_SITUACAO { get; set; }
    }
}
