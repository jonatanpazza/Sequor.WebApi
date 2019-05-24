namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLINVENTARIOCONTAGENSASSINCRONASSTATUS
    {
        public long ID { get; set; }

        public long ID_CONTAGENS_ASSINCRONAS { get; set; }

        public int STATUS { get; set; }

        [Required]
        [StringLength(50)]
        public string USUARIO { get; set; }

        public DateTime DATA_OCORRENCIA { get; set; }

        [Required]
        [StringLength(500)]
        public string MSG_ERRO { get; set; }

        public int? NUMERO_TENTATIVAS { get; set; }

        [StringLength(50)]
        public string VERSION { get; set; }
    }
}
