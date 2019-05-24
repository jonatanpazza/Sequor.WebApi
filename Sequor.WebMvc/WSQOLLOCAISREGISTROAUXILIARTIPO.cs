namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLLOCAISREGISTROAUXILIARTIPO")]
    public partial class WSQOLLOCAISREGISTROAUXILIARTIPO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int REGISTRO_AUXILIAR_TIPO { get; set; }

        [Required]
        [StringLength(100)]
        public string DESCRICAO { get; set; }

        public int? ACAO { get; set; }

        public int? FLUTUANTE { get; set; }
    }
}
