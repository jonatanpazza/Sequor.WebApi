namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLPICKINGMOVITENS
    {
        public long ID { get; set; }

        public long? ID_MOV { get; set; }

        [StringLength(50)]
        public string ITEM { get; set; }

        public DateTime? DATA_OCORRENCIA_INICIAL { get; set; }

        public DateTime? DATA_OCORRENCIA_FINAL { get; set; }

        public long? ID_SEQ_ITENS { get; set; }

        public int? TEMPO_CICLO { get; set; }

        public int? STATUS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_PAGO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_FALTANTE { get; set; }

        [StringLength(50)]
        public string LOCAL_DEBITO { get; set; }

        [StringLength(50)]
        public string LOCAL_CREDITO { get; set; }

        public bool? EMBALAGEM { get; set; }

        [StringLength(50)]
        public string VERSAO_TABLET_ULTIMA_MOVIMENTACAO { get; set; }

        [StringLength(50)]
        public string LOCAL_DEBITO_CODIGO_RASTREABILIDADE { get; set; }

        [StringLength(500)]
        public string MSG_ERRO { get; set; }

        [StringLength(50)]
        public string LOCAL_CREDITO_CODIGO_RASTREABILIDADE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_ENTREGUE { get; set; }

        public Guid? PICKING_FINISH_KEY { get; set; }
    }
}
