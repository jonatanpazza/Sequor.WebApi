namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLRECEBIMENTOCONTAGENSHIST")]
    public partial class WSQOLRECEBIMENTOCONTAGENSHIST
    {
        public long ID { get; set; }

        public long ID_CONTAGEM { get; set; }

        public int STATUS { get; set; }

        [Required]
        [StringLength(50)]
        public string USUARIO { get; set; }

        public DateTime DATA { get; set; }
    }
}
