namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLESTOQUEMOVAUXILIARREGRAS
    {
        [Key]
        public long ID_ESTOQUE_MOV_AUXILIAR_REGRAS { get; set; }

        public long ID_ESTOQUE_MOV_AUXILIAR { get; set; }

        [Required]
        [StringLength(50)]
        public string REGRA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal VALOR { get; set; }

        [Required]
        [StringLength(50)]
        public string ATRIBUTO { get; set; }

        [Required]
        [StringLength(4000)]
        public string ATRIBUTO_EX { get; set; }
    }
}
