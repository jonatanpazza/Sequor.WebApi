namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLINVENTARIOHIST")]
    public partial class WSQOLINVENTARIOHIST
    {
        [Key]
        public long ID_HIST { get; set; }

        public long ID_INVENTARIO { get; set; }

        [Required]
        [StringLength(50)]
        public string NUMERO_INVENTARIO { get; set; }

        public DateTime? DATA_DOCUMENTO { get; set; }

        public DateTime? DATA_PREV_CONTAGEM { get; set; }

        [StringLength(50)]
        public string EXERCICIO { get; set; }

        [StringLength(50)]
        public string CENTRO { get; set; }

        [StringLength(50)]
        public string DEPOSITO { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        [StringLength(50)]
        public string STATUS_CONTAGEM { get; set; }

        [StringLength(50)]
        public string STATUS_BAIXA { get; set; }

        public bool? BLOQUEIO_REGISTROS { get; set; }

        public long STATUS_ID { get; set; }

        public long? STATUS_ID_INVENTARIO { get; set; }

        public int? STATUS_STATUS { get; set; }

        [StringLength(50)]
        public string STATUS_USUARIO { get; set; }

        public DateTime? STATUS_DATA_OCORRENCIA { get; set; }

        public int? STATUS_STATUS_ESTOQUE { get; set; }

        [StringLength(500)]
        public string STATUS_MSG_ERRO { get; set; }
    }
}
