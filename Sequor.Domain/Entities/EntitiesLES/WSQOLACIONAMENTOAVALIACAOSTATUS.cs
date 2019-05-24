namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLACIONAMENTOAVALIACAOSTATUS
    {
        [Key]
        public long ID_ACIONAMENTO_AVALIACAO_STATUS { get; set; }

        public long ID_KANBAN_ACIONAMENTO { get; set; }

        public int STATUS { get; set; }

        [Required]
        [StringLength(50)]
        public string USUARIO { get; set; }

        public DateTime DATA_OCORRENCIA { get; set; }
    }
}
