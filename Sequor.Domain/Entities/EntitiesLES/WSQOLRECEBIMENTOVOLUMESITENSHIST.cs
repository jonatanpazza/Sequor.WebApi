namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLRECEBIMENTOVOLUMESITENSHIST")]
    public partial class WSQOLRECEBIMENTOVOLUMESITENSHIST
    {
        public long ID { get; set; }

        public long ID_RECEBIMENTO_VOLUMES_ITENS { get; set; }

        public int STATUS { get; set; }

        [Required]
        [StringLength(50)]
        public string USUARIO { get; set; }

        public DateTime DATA { get; set; }
    }
}
