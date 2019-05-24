namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLINVENTARIOTAREFASDETALHES
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID_TAREFA_DETALHES { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_TAREFA { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string REGRA { get; set; }

        [StringLength(200)]
        public string ATRIBUTO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VALOR { get; set; }
    }
}
