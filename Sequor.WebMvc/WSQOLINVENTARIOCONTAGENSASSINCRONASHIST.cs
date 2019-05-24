namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLINVENTARIOCONTAGENSASSINCRONASHIST")]
    public partial class WSQOLINVENTARIOCONTAGENSASSINCRONASHIST
    {
        [Key]
        public long ID_HIST { get; set; }

        public long ID_CONTAGEM_ASSINCRONA { get; set; }

        public long ID_TAREFA { get; set; }

        public int CONTAGEM { get; set; }

        [Required]
        [StringLength(20)]
        public string USUARIO { get; set; }

        public int TIPO_AUDITORIA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal QUANTIDADE_CONTADA { get; set; }

        public DateTime? DATA { get; set; }

        public long STATUS_ID { get; set; }

        public long STATUS_ID_CONTAGENS_ASSINCRONAS { get; set; }

        public int STATUS_STATUS { get; set; }

        [Required]
        [StringLength(50)]
        public string STATUS_USUARIO { get; set; }

        public DateTime STATUS_DATA_OCORRENCIA { get; set; }

        [Required]
        [StringLength(500)]
        public string STATUS_MSG_ERRO { get; set; }

        public int? STATUS_NUMERO_TENTATIVAS { get; set; }

        [StringLength(50)]
        public string STATUS_VERSION { get; set; }
    }
}
