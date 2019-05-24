namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLQLCSEGREGADONBR")]
    public partial class WSQOLQLCSEGREGADONBR
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_SEGREGACAO { get; set; }

        public int? TAMANHO_AMOSTRA { get; set; }

        public int? NUMERO_ACEITACAO { get; set; }

        public int? NUMERO_REJEICAO { get; set; }

        [StringLength(50)]
        public string NIVEL_INSPECAO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? NQA { get; set; }

        [StringLength(50)]
        public string REGIME_INSPECAO { get; set; }

        [StringLength(50)]
        public string TIPO_AMOSTRA { get; set; }

        [StringLength(50)]
        public string CODIGO_LITERAL { get; set; }

        public bool? REPROVACAO_DEFEITO_CRITICO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TAMANHO_LOTE { get; set; }

        public long? ID_VINCULO { get; set; }

        public bool? PERMITIR_COMUTACAO_REGIME_ATENUADO { get; set; }

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
