namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLINVENTARIOCONTAGENSASSINCRONAS
    {
        [Key]
        public long ID_CONTAGEM_ASSINCRONA { get; set; }

        public long ID_TAREFA { get; set; }

        public int CONTAGEM { get; set; }

        [Required]
        [StringLength(20)]
        public string USUARIO { get; set; }

        public int TIPO_AUDITORIA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal QUANTIDADE_CONTADA { get; set; }

        public DateTime? DATA { get; set; }

        [StringLength(50)]
        public string UNIDADE_MEDIDA_CONTADA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_INFORMADA { get; set; }

        [StringLength(50)]
        public string UNIDADE_MEDIDA_INFORMADA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FATOR_CONVERSAO { get; set; }

        [StringLength(100)]
        public string LOCAL_CONTAGEM { get; set; }
    }
}
