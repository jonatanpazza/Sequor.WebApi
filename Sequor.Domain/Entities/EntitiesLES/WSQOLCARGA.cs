namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLCARGA")]
    public partial class WSQOLCARGA
    {
        public long ID { get; set; }

        [Required]
        [StringLength(20)]
        public string USUARIO_CRIACAO { get; set; }

        public DateTime DATA_INICIAL { get; set; }

        public DateTime? DATA_FINAL { get; set; }

        [StringLength(100)]
        public string TRANSPORTADORA { get; set; }

        public long? ID_MOTORISTA { get; set; }

        public int? TIPO_VEICULO { get; set; }

        [StringLength(50)]
        public string PLACA { get; set; }

        public long? PORTARIA { get; set; }
    }
}
