namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLRESERVA")]
    public partial class WSQOLRESERVA
    {
        [Key]
        [StringLength(50)]
        public string CODIGO_RESERVA { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        public DateTime? DATA_CRIACAO { get; set; }

        [StringLength(50)]
        public string USUARIO_RESERVA { get; set; }

        public int? STATUS { get; set; }
    }
}
