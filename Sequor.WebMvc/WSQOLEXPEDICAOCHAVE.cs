namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLEXPEDICAOCHAVE")]
    public partial class WSQOLEXPEDICAOCHAVE
    {
        public long ID { get; set; }

        [Required]
        [StringLength(50)]
        public string CHAVE { get; set; }

        [Required]
        [StringLength(50)]
        public string DESCRICAO { get; set; }

        [Required]
        [StringLength(50)]
        public string TIPO_EXPEDICAO { get; set; }

        public int? QUESTIONARIO_EXPEDICAO { get; set; }

        public int? EQUIPE { get; set; }

        public int LEITURA_CODIGO_VOLUME { get; set; }

        public int LEITURA_LOCAL_DESTINO { get; set; }

        public int LEITURA_CHAVE_NOTA_FISCAL { get; set; }

        public int LEITURA_RASTREABILIDADE_COMPONENTE { get; set; }

        public int AGRUPAMENTO_DOC_TRANSPORTE { get; set; }

        public int NOTIFICACAO_CLIENTE { get; set; }

        [Required]
        [StringLength(50)]
        public string DEPOSITO { get; set; }

        public int ETIQUETA_SEQUENCIA_CARREGAMENTO { get; set; }
    }
}
