namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLKANBANIDENTIFICACAO")]
    public partial class WSQOLKANBANIDENTIFICACAO
    {
        public long ID { get; set; }

        public int? ID_COMPONENT_DADOS_ORDEM_PROD { get; set; }

        public int? ID_DADOS_ORDEM_PROD { get; set; }

        [StringLength(50)]
        public string MATERIAL { get; set; }

        [StringLength(50)]
        public string COMPONENTE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE { get; set; }

        [StringLength(50)]
        public string UNIDADE { get; set; }

        [StringLength(50)]
        public string ID_ { get; set; }

        [StringLength(50)]
        public string PRIORIDADE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? REFUGO { get; set; }

        [StringLength(50)]
        public string OPERACAO { get; set; }

        public int? RESERVA { get; set; }

        public int? RESERVA_ITEM { get; set; }

        [StringLength(50)]
        public string BASE { get; set; }

        [StringLength(50)]
        public string BASE_ISO { get; set; }

        [StringLength(50)]
        public string ITEM { get; set; }

        [StringLength(50)]
        public string SERIE { get; set; }

        [StringLength(50)]
        public string DEPOSITO { get; set; }

        [StringLength(50)]
        public string STATUS_COMPONENT { get; set; }

        [StringLength(50)]
        public string ORIGEM_MATERIALPCP2 { get; set; }

        [StringLength(50)]
        public string KANBAN_LOCAL { get; set; }

        [StringLength(50)]
        public string CHAVE_PICKING { get; set; }

        [StringLength(50)]
        public string CODIGO_RASTREABILIDADE { get; set; }

        [StringLength(50)]
        public string LOCAL_TRABALHO_ORDEM_PROD { get; set; }

        [StringLength(50)]
        public string ORIGEM { get; set; }

        public DateTime? DATA_REG { get; set; }

        public bool? STATUS { get; set; }
    }
}
