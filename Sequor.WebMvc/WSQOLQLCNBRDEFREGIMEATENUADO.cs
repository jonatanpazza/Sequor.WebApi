namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLQLCNBRDEFREGIMEATENUADO")]
    public partial class WSQOLQLCNBRDEFREGIMEATENUADO
    {
        [Key]
        [Column(Order = 0, TypeName = "numeric")]
        public decimal NQA { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TAMANHO_AMOSTRA_MINIMO { get; set; }

        public int? MAXIMO_AMOSTRAS_NOK { get; set; }
    }
}
