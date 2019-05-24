namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLESTOQUEMOVAUXILIARSTATUS
    {
        [Key]
        public long ID_ESTOQUE_MOV_AUXILIAR_STATUS { get; set; }

        public long ID_ESTOQUE_MOV_AUXILIAR { get; set; }

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

        public int? CODIGO_SERVICO { get; set; }
    }
}
