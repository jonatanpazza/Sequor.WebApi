namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLKANBANDEFINICOESHIST")]
    public partial class WSQOLKANBANDEFINICOESHIST
    {
        [Key]
        public long ID_KANBAN_DEFINICOES_HIST { get; set; }

        public long? ID_KANBAN_DEFINICOES { get; set; }

        [StringLength(50)]
        public string CODIGO_LOCAL_CONSUMO { get; set; }

        [StringLength(50)]
        public string GRUPO { get; set; }

        [StringLength(50)]
        public string CLIENTE { get; set; }

        [StringLength(50)]
        public string CODIGO_PECA { get; set; }

        public int? TIPO_RECIPIENTE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QTD_MAX_ABASTECIMENTO { get; set; }

        public int? QTD_RECIPIENTES { get; set; }

        [StringLength(50)]
        public string CHAVE_PICKING { get; set; }

        public bool? UTILIZAR_LOTE_MINIMO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QTD_LOTE_MINIMO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PERCENTUAL_REPOSICAO_CRITICA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PERCENTUAL_REPOSICAO_URGENTE { get; set; }

        public int? VERIFICA_OP_ABERTA_PERIODO { get; set; }

        public int? VERIFICA_OP_ABERTA { get; set; }

        public bool? ESTOQUE_KANBAN_SUFICIENTE { get; set; }

        public bool? ESTOQUE_ORIGEM_SUFICIENTE { get; set; }

        public int? ESTRATEGIA_GERACAO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PERCENTUAL_DEMANDA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QTD_MAQUINAS_DIMENSIONAMENTO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PERIODO_DIAS { get; set; }

        [StringLength(1)]
        public string OPERACAO { get; set; }

        public DateTime? DATA_OCORRENCIA { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        [StringLength(50)]
        public string MACHINE_NAME { get; set; }

        [StringLength(50)]
        public string OS_USER_NAME { get; set; }

        public string LISTAGEM_FILTRO_CRITERIA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QTD_MAX_RECIPIENTE { get; set; }

        [StringLength(200)]
        public string NOME_ARQUIVO { get; set; }

        [StringLength(50)]
        public string GRUPO_PICKING { get; set; }
    }
}
