namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLKANBANACIONAMENTOSTATUS
    {
        [Key]
        public long ID_KANBAN_ACIONAMENTO_STATUS { get; set; }

        public long ID_KANBAN_ACIONAMENTO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PERCENTUAL_DEMANDA { get; set; }

        public int STATUS { get; set; }

        [Required]
        [StringLength(50)]
        public string USUARIO { get; set; }

        public DateTime DATA_OCORRENCIA { get; set; }

        [StringLength(500)]
        public string MSG_ERRO { get; set; }

        public TimeSpan? SVC_PROCESS_TIME { get; set; }

        public Guid? SVC_PROCESS_KEY { get; set; }

        [StringLength(50)]
        public string MACHINE_NAME { get; set; }

        [StringLength(50)]
        public string OS_USER_NAME { get; set; }
    }
}
