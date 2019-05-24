namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLKANBANDEFINICOES
    {
        [Key]
        public long ID_KANBAN_DEFINICOES { get; set; }

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

        [Column(TypeName = "numeric")]
        public decimal? QTD_MAX_RECIPIENTE { get; set; }

        [StringLength(50)]
        public string GRUPO_PICKING { get; set; }
    }
}
