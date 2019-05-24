namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLINVENTARIOTAREFASTIPO")]
    public partial class WSQOLINVENTARIOTAREFASTIPO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_TAREFA_TIPO { get; set; }

        [StringLength(50)]
        public string DESCRICAO { get; set; }
    }
}
