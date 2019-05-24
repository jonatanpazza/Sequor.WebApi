namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLQLCNBRDEFOLD")]
    public partial class WSQOLQLCNBRDEFOLD
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(1)]
        public string CODIGO_LITERAL { get; set; }

        [Key]
        [Column(Order = 1, TypeName = "numeric")]
        public decimal NQA { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string REGIME_INSPECAO { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string TIPO_AMOSTRA { get; set; }

        public int? TAMANHO_AMOSTRA { get; set; }

        public int? NUMERO_ACEITACAO { get; set; }

        public int? NUMERO_REJEICAO { get; set; }

        public int? NUMERO_ACEITACAO_2 { get; set; }

        public int? NUMERO_REJEICAO_2 { get; set; }

        public int? NUMERO_ACEITACAO_3 { get; set; }

        public int? NUMERO_REJEICAO_3 { get; set; }

        public int? NUMERO_ACEITACAO_4 { get; set; }

        public int? NUMERO_REJEICAO_4 { get; set; }

        public int? NUMERO_ACEITACAO_5 { get; set; }

        public int? NUMERO_REJEICAO_5 { get; set; }

        public int? NUMERO_ACEITACAO_6 { get; set; }

        public int? NUMERO_REJEICAO_6 { get; set; }

        public int? NUMERO_ACEITACAO_7 { get; set; }

        public int? NUMERO_REJEICAO_7 { get; set; }
    }
}
