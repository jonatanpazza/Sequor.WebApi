namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLEXPEDICAOVOLUME")]
    public partial class WSQOLEXPEDICAOVOLUME
    {
        public long ID { get; set; }

        public long? ID_REMESSA { get; set; }

        public long? ID_DOCUMENTO_TRANSPORTE { get; set; }

        [StringLength(50)]
        public string CODIGO_REMESSA { get; set; }

        [Required]
        [StringLength(50)]
        public string CODIGO_VOLUME { get; set; }

        [Required]
        [StringLength(50)]
        public string CODIGO_RASTREABILIDADE { get; set; }

        [StringLength(50)]
        public string ORDEM_PRODUCAO { get; set; }

        public int? TIPO_VOLUME { get; set; }

        [StringLength(50)]
        public string TIPO_EXPEDICAO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PESO_TOTAL_CALCULADO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PESO_TOTAL_VOLUME { get; set; }

        [StringLength(50)]
        public string CHAVE_EXPEDICAO_PLANEJAMENTO { get; set; }

        [StringLength(50)]
        public string LOCAL_ENTREGA { get; set; }

        public int? TIPO_PLANEJAMENTO_LES { get; set; }

        public DateTime? DATA_SEPARACAO_PLANEJAMENTO { get; set; }

        public DateTime? DATA_TRANSPORTE_PLANEJAMENTO { get; set; }

        public int? OBRIGAR_SEQUENCIA_PLANEJAMENTO { get; set; }

        [StringLength(50)]
        public string DOC_TRANSPORTE_AUX_PLANEJAMENTO { get; set; }

        [StringLength(50)]
        public string TAM_CAMINHAO_PLANEJAMENTO { get; set; }

        [StringLength(250)]
        public string DETALHE_PLANEJAMENTO { get; set; }

        public Guid? AGRUPAMENTO_LOGISTICO { get; set; }

        public Guid? AGRUPAMENTO_CARREGAMENTO { get; set; }

        [StringLength(50)]
        public string MODULO { get; set; }

        public int? STATUS { get; set; }

        public int? CONTADOR { get; set; }

        [StringLength(50)]
        public string USUARIO_ULTIMA_MOVIMENTACAO { get; set; }

        public DateTime? DATA_ULTIMA_MOVIMENTACAO { get; set; }

        [StringLength(250)]
        public string OBSERVACAO { get; set; }
    }
}
