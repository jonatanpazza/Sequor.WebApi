namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLINVENTARIOCONTAGEMHIST")]
    public partial class WSQOLINVENTARIOCONTAGEMHIST
    {
        [Key]
        public long ID_HIST { get; set; }

        public long ID_CONTAGEM { get; set; }

        public long ID_TAREFA { get; set; }

        public int NUMERO_CONTAGEM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal QUANTIDADE_CONTADA { get; set; }

        public DateTime? DATA_OCORRENCIA { get; set; }

        public long STATUS_ID { get; set; }

        public long STATUS_ID_CONTAGEM { get; set; }

        public int? STATUS_STATUS { get; set; }

        [StringLength(50)]
        public string STATUS_USUARIO { get; set; }

        public DateTime? STATUS_DATA_OCORRENCIA { get; set; }

        [StringLength(500)]
        public string STATUS_MSG_ERRO { get; set; }
    }
}
