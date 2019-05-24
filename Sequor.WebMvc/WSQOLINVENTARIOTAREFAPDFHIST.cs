namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLINVENTARIOTAREFAPDFHIST")]
    public partial class WSQOLINVENTARIOTAREFAPDFHIST
    {
        public long ID { get; set; }

        public long ID_TAREFA { get; set; }

        public int CONTAGEM { get; set; }

        public DateTime DATA { get; set; }

        [Required]
        [StringLength(100)]
        public string MACHINE_NAME { get; set; }

        [Required]
        [StringLength(100)]
        public string USER_MACHINE_NAME { get; set; }

        public Guid? PRINT_GROUP_KEY { get; set; }
    }
}
