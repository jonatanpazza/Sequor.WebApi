namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLPICKINGCHAVE")]
    public partial class WSQOLPICKINGCHAVE
    {
        [Key]
        [StringLength(50)]
        public string CHAVE { get; set; }

        [StringLength(50)]
        public string DESCRICAO { get; set; }

        public bool? GRUPO { get; set; }

        public bool? USUARIO { get; set; }

        public bool? OBRIGAR_SEQUENCIAMENTO { get; set; }

        public bool? LEITURA_ITEM_OBRIGATORIA { get; set; }

        public bool? LEITURA_LOCAL_OBRIGATORIA { get; set; }

        [StringLength(50)]
        public string ESQUEMA_CALENDARIO { get; set; }

        public long? TIPO_LOCAL_DESTINO { get; set; }

        [StringLength(50)]
        public string LOCAL { get; set; }

        public int? TIPO_APONTAMENTO_DADOS { get; set; }

        public int? GERA_EMBALAGEM { get; set; }

        public int? BLOQUEIA_USUARIO { get; set; }

        public bool? EXPEDICAO { get; set; }

        public bool? ACEITA_FALTANTE { get; set; }

        public bool? PERMITIR_VISUALIZACAO { get; set; }

        public bool? SELECAO_MULTIPLA { get; set; }

        public bool? LEITURA_COD_BARRAS_OBRIGATORIA { get; set; }

        public bool? GERA_LOCAL_FLUTUANTE { get; set; }

        public bool? GERAR_PICKING_FINALIZACAO { get; set; }

        [StringLength(50)]
        public string CHAVE_GERACAO_PICKING { get; set; }

        public bool? VERIFICAR_QUALIDADE { get; set; }

        [StringLength(50)]
        public string MODULO_QUALIDADE { get; set; }

        [StringLength(50)]
        public string FORNECEDOR_QUALIDADE { get; set; }

        [StringLength(50)]
        public string PROCEDURE_VALIDA_LOCAL_DESTINO { get; set; }

        public bool? PERMITIR_ITEM_MULTIPLOS_VOLUMES { get; set; }

        public bool? GERAR_ETIQUETA_LOCAL_ENTREGA { get; set; }

        public int? ID_PRINTER { get; set; }

        public int? COMP_PICKING { get; set; }

        public long? QTD_MAX_LOCAIS_FLUTUANTES { get; set; }

        public bool? GERAR_EXPEDICAO { get; set; }

        [StringLength(100)]
        public string LOCAL_ALOCACAO { get; set; }

        public bool? BLOQUEIA_RESERVAR_APOS_RESERVADO { get; set; }

        public bool? CONTROLAR_RASTREABILIDADE { get; set; }

        public int? QUEBRA_LOTE_MINIMO { get; set; }

        public int? FINALIZACAO_TIPO { get; set; }

        public int? GRUPO_TIPO_LISTAGEM { get; set; }

        public int? SEQUENCIAMENTO_TIPO { get; set; }

        public int? SEQUENCIAMENTO_AUTOMATICO { get; set; }

        public int? TIPO_LISTA_DATA { get; set; }
    }
}
