namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLRECEBIMENTOVOLUMESHIST")]
    public partial class WSQOLRECEBIMENTOVOLUMESHIST
    {
        public long ID { get; set; }

        public long ID_RECEBIMENTO_VOLUME { get; set; }

        public int STATUS { get; set; }

        [Required]
        [StringLength(20)]
        public string USUARIO { get; set; }

        public DateTime DATA { get; set; }
    }
}
