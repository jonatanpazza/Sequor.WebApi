namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLINVENTARIOEQUIPE")]
    public partial class WSQOLINVENTARIOEQUIPE
    {
        [Key]
        [StringLength(50)]
        public string CODIGO_EQUIPE { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRICAO { get; set; }

        public int? PERMISSAO_CONTAGEM { get; set; }
    }
}
