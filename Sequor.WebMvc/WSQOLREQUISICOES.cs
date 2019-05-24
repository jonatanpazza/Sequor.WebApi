namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLREQUISICOES
    {
        [Required]
        [StringLength(50)]
        public string CODIGO_REQUISICAO { get; set; }

        public long ID { get; set; }

        [StringLength(50)]
        public string CHAVE_PICKING { get; set; }

        public DateTime? DATA_CRIACAO { get; set; }

        public DateTime? DATA_NECESSIDADE { get; set; }

        [StringLength(50)]
        public string LOCAL_ENTREGA { get; set; }

        [StringLength(50)]
        public string USUARIO_ENTREGA { get; set; }

        public int? TIPO_ENTREGA { get; set; }

        public int? STATUS { get; set; }

        [StringLength(50)]
        public string ORIGEM_REQUISICAO { get; set; }

        public int? TIPO_ORIGEM { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        [StringLength(500)]
        public string OBSERVACAO { get; set; }

        [StringLength(50)]
        public string SETOR_APROVACAO { get; set; }

        [StringLength(50)]
        public string LINHA_ORIGEM { get; set; }

        [StringLength(50)]
        public string ESTACAO_ORIGEM { get; set; }

        [StringLength(50)]
        public string ORDEM_PRODUCAO { get; set; }

        [StringLength(50)]
        public string USUARIO_LIBERACAO { get; set; }

        public DateTime? DATA_LIBERACAO { get; set; }
    }
}
