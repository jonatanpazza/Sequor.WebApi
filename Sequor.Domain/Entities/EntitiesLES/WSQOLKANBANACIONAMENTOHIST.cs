namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLKANBANACIONAMENTOHIST")]
    public partial class WSQOLKANBANACIONAMENTOHIST
    {
        [Key]
        public long ID_KANBAN_ACIONAMENTO_HIST { get; set; }

        public long ID_KANBAN_ACIONAMENTO { get; set; }

        public long ID_KANBAN_DEFINICOES { get; set; }

        public long? ID_KANBAN_ACIONAMENTO_ORIGEM { get; set; }

        [Required]
        [StringLength(50)]
        public string CODIGO_RASTREABILIDADE { get; set; }

        [StringLength(50)]
        public string CODIGO_RASTREABILIDADE_ORIGEM { get; set; }

        [Required]
        [StringLength(50)]
        public string CODIGO_LOCAL_FLUTUANTE { get; set; }

        [Required]
        [StringLength(50)]
        public string CODIGO_LOCAL_CONSUMO { get; set; }

        [Required]
        [StringLength(50)]
        public string GRUPO { get; set; }

        [Required]
        [StringLength(50)]
        public string CLIENTE { get; set; }

        [Required]
        [StringLength(50)]
        public string CODIGO_PECA { get; set; }

        public int TIPO_RECIPIENTE { get; set; }

        public int CONTADOR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal QTD_MAX_ABASTECIMENTO { get; set; }

        public int QTD_RECIPIENTES { get; set; }

        [Required]
        [StringLength(50)]
        public string CHAVE_PICKING { get; set; }

        public bool? UTILIZAR_LOTE_MINIMO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal QTD_LOTE_MINIMO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PERCENTUAL_REPOSICAO_CRITICA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal PERCENTUAL_REPOSICAO_URGENTE { get; set; }

        public int? VERIFICA_OP_ABERTA_PERIODO { get; set; }

        public int VERIFICA_OP_ABERTA { get; set; }

        public bool ESTOQUE_KANBAN_SUFICIENTE { get; set; }

        public bool ESTOQUE_ORIGEM_SUFICIENTE { get; set; }

        public int ESTRATEGIA_GERACAO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PERCENTUAL_DEMANDA { get; set; }

        public int ACIONAMENTO_TIPO { get; set; }

        public int STATUS { get; set; }

        [Required]
        [StringLength(50)]
        public string USUARIO { get; set; }

        public DateTime DATA_OCORRENCIA { get; set; }

        [StringLength(500)]
        public string MSG_ERRO { get; set; }

        public TimeSpan? SVC_PROCESS_TIME { get; set; }

        public Guid? SVC_PROCESS_KEY { get; set; }

        [StringLength(50)]
        public string MACHINE_NAME { get; set; }

        [StringLength(50)]
        public string OS_USER_NAME { get; set; }
    }
}
