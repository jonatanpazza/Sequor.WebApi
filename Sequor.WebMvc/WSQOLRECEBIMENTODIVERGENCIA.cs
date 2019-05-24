namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLRECEBIMENTODIVERGENCIA")]
    public partial class WSQOLRECEBIMENTODIVERGENCIA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CODIGO_RECEBIMENTO { get; set; }

        [Key]
        [Column(Order = 1)]
        public long ID { get; set; }

        public DateTime? DATA_CRIACAO { get; set; }

        public int? TIPO_DIVERGENCIA { get; set; }

        [StringLength(50)]
        public string SETOR_LANCAMENTO { get; set; }

        [StringLength(50)]
        public string SETOR_ENVIADO { get; set; }

        [StringLength(50)]
        public string USUARIO_LANCAMENTO { get; set; }

        public int? STATUS { get; set; }

        [StringLength(50)]
        public string WORKFLOW_UTILIZADO { get; set; }

        public bool? ESTORNADO { get; set; }

        public bool? FINALIZADO { get; set; }

        public bool? ORIGEM { get; set; }

        [StringLength(500)]
        public string OBSERVACAO { get; set; }

        public bool? INTERNO { get; set; }

        public bool? ENTRADA { get; set; }
    }
}
