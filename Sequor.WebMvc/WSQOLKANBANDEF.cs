namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLKANBANDEF")]
    public partial class WSQOLKANBANDEF
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string LOCAL_CONSUMO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QTD_DEMANDA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QTD_REPOSICAO_MINIMA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QTD_REPOSICAO_CRITICA { get; set; }

        public bool? PERMITE_ATUALIZACAO_ERP { get; set; }

        public int? TIPO_RECIPIENTE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QTD_MAXIMA_RECIPIENTE { get; set; }

        [StringLength(50)]
        public string CHAVE_PICKING { get; set; }

        public int? CARTOES_EXCEDENTES { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TEMPO_MEDIO_ABASTECIMENTO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TEMPO_MEDIO_CONSUMO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TEMPO_LIMITE_ABASTECIMENTO { get; set; }

        public bool? PERMITE_REQUISICAO_FORCADA { get; set; }

        [StringLength(50)]
        public string SUGESTAO_UTILIZADA { get; set; }

        [StringLength(50)]
        public string CENTRO_TRABALHO { get; set; }

        public int? CONTADOR { get; set; }

        public DateTime? DATA_ULTIMA_MOVIMENTACAO { get; set; }

        public bool? ATIVO { get; set; }
    }
}
