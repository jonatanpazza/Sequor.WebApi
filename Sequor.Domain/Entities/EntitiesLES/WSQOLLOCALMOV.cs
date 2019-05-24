namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLLOCALMOV")]
    public partial class WSQOLLOCALMOV
    {
        public long ID { get; set; }

        [Required]
        [StringLength(50)]
        public string CODIGO_LOCAL { get; set; }

        public int? STATUS { get; set; }

        public int? ID_TIPO_RECIPIENTE { get; set; }

        [StringLength(50)]
        public string CODIGO_LOCAL_ENTREGA { get; set; }

        public DateTime? DATA_GERACAO { get; set; }

        public DateTime? DATA_ULTIMA_MOVIMENTACAO { get; set; }

        [StringLength(50)]
        public string USUARIO_GERACAO { get; set; }

        [StringLength(50)]
        public string USUARIO_ULTIMA_MOVIMENTACAO { get; set; }

        public bool? IMPRESSO { get; set; }
    }
}
