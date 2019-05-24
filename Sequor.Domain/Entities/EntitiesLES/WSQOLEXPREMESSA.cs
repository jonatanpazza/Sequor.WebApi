namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLEXPREMESSA")]
    public partial class WSQOLEXPREMESSA
    {
        [Key]
        [StringLength(50)]
        public string CODIGO_REMESSA { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        public DateTime? DATA_REMESSA { get; set; }

        [StringLength(50)]
        public string LOCAL_EXPEDICAO { get; set; }

        [StringLength(50)]
        public string CODIGO_CLIENTE { get; set; }

        [StringLength(50)]
        public string CODIGO_TRANSPORTADORA { get; set; }

        [StringLength(50)]
        public string CODIGO_MOTIVO { get; set; }

        [StringLength(50)]
        public string STATUS_ERP { get; set; }

        public int? STATUS_LES { get; set; }

        public bool? STATUS_ENVIO_ERP { get; set; }

        [StringLength(50)]
        public string GRUPO_REMESSA { get; set; }

        public int? SEQUENCIA_DOCUMENTO_TRANSPORTE { get; set; }

        public int? SEQUENCIA_GRUPO_REMESSAS { get; set; }

        public int? OBRIGAR_SEQUENCIAMENTO { get; set; }

        public int? NUM_ETAPA_TRANSPORTE { get; set; }

        [StringLength(50)]
        public string DOCUMENTO_FATURAMENTO { get; set; }

        [StringLength(50)]
        public string NUM_DOCUMENTO_TRANSPORTE { get; set; }

        [StringLength(50)]
        public string CHAVE_EXPEDICAO_PLANEJAMENTO { get; set; }

        [StringLength(50)]
        public string LOCAL_ENTREGA_PLANEJAMENTO { get; set; }

        public int? TIPO_PLANEJAMENTO_LES { get; set; }

        public DateTime? DATA_SEPARACAO_PLANEJAMENTO { get; set; }

        public DateTime? DATA_TRANSPORTE_PLANEJAMENTO { get; set; }

        public int? OBRIGAR_SEQUENCIA_PLANEJAMENTO { get; set; }

        [StringLength(50)]
        public string TAM_CAMINHAO_PLANEJAMENTO { get; set; }

        [StringLength(250)]
        public string DETALHE_PLANEJAMENTO { get; set; }

        [StringLength(50)]
        public string STATUS_GLOBAL_PICKING { get; set; }

        [StringLength(50)]
        public string DESC_STATUS_GLOBAL_PICKING { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VOLUME_TOTAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PESO_TOTAL { get; set; }

        [StringLength(50)]
        public string UNIDADE_PESO { get; set; }

        public int? DISPONIVEL { get; set; }

        [StringLength(50)]
        public string USUARIO_ULTIMA_MOVIMENTACAO { get; set; }

        public DateTime? DATA_ULTIMA_MOVIMENTACAO { get; set; }

        [StringLength(250)]
        public string OBSERVACAO { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        public DateTime? MODIFICADO_EM { get; set; }

        [StringLength(50)]
        public string STATUS_ENVIO_ERP_CHAR { get; set; }
    }
}
