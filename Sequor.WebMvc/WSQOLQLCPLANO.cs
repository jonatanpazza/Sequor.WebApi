namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLQLCPLANO")]
    public partial class WSQOLQLCPLANO
    {
        [Key]
        public int ID_PLANO_QUALIDADE { get; set; }

        [Required]
        [StringLength(100)]
        public string PLANO { get; set; }

        [StringLength(100)]
        public string DESCRICAO_PLANO { get; set; }

        public bool? ESTORNADO { get; set; }

        public bool? PUBLICADO { get; set; }

        public DateTime? DATA_GERACAO { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        public int? TIPO_PLANO { get; set; }

        [StringLength(50)]
        public string SCOPE { get; set; }
    }
}
