namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLLOCAIS
    {
        [Key]
        public long ID_LOCAL { get; set; }

        [Required]
        [StringLength(50)]
        public string CODIGO { get; set; }

        [Required]
        [StringLength(50)]
        public string LOCAL_FISICO { get; set; }

        public int TIPO { get; set; }

        [StringLength(100)]
        public string ENDERECO { get; set; }

        public int? NUMERO { get; set; }

        [StringLength(100)]
        public string COMPLEMENTO { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        [Column(TypeName = "date")]
        public DateTime? VALIDADE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? GIS_LONGITUDE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? GIS_LATITUDE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? GIS_ALTITUDE { get; set; }

        public int? STATUS_LOCAL { get; set; }

        public int? RESTRICAO_ENDERECO { get; set; }

        public bool? PERMITE_INVENTARIO { get; set; }

        public bool? MRP { get; set; }

        public bool? ACEITAR_MAIS_PRODUTO { get; set; }

        public bool? RM_MANUAL { get; set; }

        public bool? RM_AUTOMATICA { get; set; }

        public bool? OP { get; set; }

        public bool? OUTRAS_REQUISICOES { get; set; }

        public bool? RECIPIENTE { get; set; }

        public int? TIPO_RECIPIENTE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PESO_MAXIMO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ALTURA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LARGURA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? COMPRIMENTO { get; set; }

        [StringLength(50)]
        public string LOCAL_INTEGRACAO { get; set; }

        public bool? LOCAL_EQUIVALENCIA_ERP { get; set; }

        [StringLength(50)]
        public string UNIDADE_NEGOCIO { get; set; }

        [StringLength(50)]
        public string CENTRO_CUSTOS { get; set; }

        public bool? LOCAL_TERCEIROS { get; set; }

        public bool? EXTERNO { get; set; }

        public int? CONTROLE_CODIGO { get; set; }

        public bool? FLUTUANTE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PESO_MAXIMO_UNITARIO { get; set; }

        public bool? LOCAL_EMBALAGENS { get; set; }

        public int? ID_PRINTER_MODULE { get; set; }

        public int? TIPO_INTEGRACAO_ERP { get; set; }

        public bool? LOCAL_EQUIVALENTE_ERP { get; set; }

        [StringLength(50)]
        public string CODIGO_FORNECEDOR { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        public DateTime? DATA_ULTIMA_MOVIMENTACAO { get; set; }

        public int? QUALIDADE { get; set; }

        public bool? BLOQUEAR_DEBITO_COMP_FILTRO { get; set; }

        public int REGISTRO_AUXILIAR_TIPO { get; set; }

        public int? ACURACIDADE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QTD_LOTE_MINIMO { get; set; }

        [StringLength(50)]
        public string TAMANHO_LOCAL { get; set; }

        public int? LIMPAR_CODIGO_RASTREABILIDADE_PICKING { get; set; }

        public int? LIMPAR_CODIGO_RASTREABILIDADE_OP { get; set; }

        public int? LIMPAR_CODIGO_RASTREABILIDADE_RECEBIMENTO { get; set; }
    }
}
