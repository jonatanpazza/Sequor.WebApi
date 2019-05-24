namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLPEDIDONF")]
    public partial class WSQOLPEDIDONF
    {
        public long ID { get; set; }

        public long? ID_PEDIDO_ITEM { get; set; }

        public long? ID_NF_ITEM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_RECEBIDA { get; set; }

        public DateTime? DATA_OCORRENCIA { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        [StringLength(50)]
        public string JUSTIFICATIVA_VARIACAO_NF { get; set; }

        [StringLength(500)]
        public string OBS_VARIACAO_NF { get; set; }

        [StringLength(50)]
        public string CODIGO_JUSTIFICATIVA_VARIACAO { get; set; }

        [StringLength(500)]
        public string OBS { get; set; }

        public long? ID_RECEBIMENTO { get; set; }

        public long? ID_NF { get; set; }

        public long? ID_PEDIDO { get; set; }

        public int? STATUS { get; set; }

        public long? ID_FORNECEDOR { get; set; }

        [StringLength(50)]
        public string CODIGO_PECA { get; set; }

        public long? ID_RECEBIMENTO_ERP { get; set; }

        public long? ID_RECEBIMENTO_ITEM_ERP { get; set; }

        [StringLength(50)]
        public string CODIGO_FORNECEDOR { get; set; }
    }
}
