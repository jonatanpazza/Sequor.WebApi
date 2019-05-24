namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLINVENTARIOTAREFASSTATUS
    {
        public long ID { get; set; }

        public long ID_TAREFA { get; set; }

        public int STATUS { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        public DateTime? DATA_OCORRENCIA { get; set; }

        [StringLength(500)]
        public string MSG_ERRO { get; set; }

        [StringLength(50)]
        public string VERSION { get; set; }

        public int PRIORITY { get; set; }

        public int NCOUNT { get; set; }

        [StringLength(100)]
        public string LOCAL_CONTAGEM { get; set; }
    }
}
