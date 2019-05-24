namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLKANBANACIONAMENTOTIPO")]
    public partial class WSQOLKANBANACIONAMENTOTIPO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ACIONAMENTO_TIPO { get; set; }

        [Required]
        [StringLength(100)]
        public string DESCRICAO { get; set; }
    }
}
