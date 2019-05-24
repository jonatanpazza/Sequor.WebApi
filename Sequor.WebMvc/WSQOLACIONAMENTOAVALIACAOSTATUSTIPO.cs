namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLACIONAMENTOAVALIACAOSTATUSTIPO")]
    public partial class WSQOLACIONAMENTOAVALIACAOSTATUSTIPO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STATUS { get; set; }

        [Required]
        [StringLength(100)]
        public string DESCRICAO { get; set; }
    }
}
