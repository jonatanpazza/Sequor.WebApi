namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLINVENTARIOCONTAGEM")]
    public partial class WSQOLINVENTARIOCONTAGEM
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID_CONTAGEM { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_TAREFA { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NUMERO_CONTAGEM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal QUANTIDADE_CONTADA { get; set; }

        public DateTime? DATA_OCORRENCIA { get; set; }

        [StringLength(50)]
        public string UNIDADE_MEDIDA_CONTADA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_INFORMADA { get; set; }

        [StringLength(50)]
        public string UNIDADE_MEDIDA_INFORMADA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FATOR_CONVERSAO { get; set; }
    }
}
