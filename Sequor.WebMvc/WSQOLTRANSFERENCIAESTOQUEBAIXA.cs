namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLTRANSFERENCIAESTOQUEBAIXA")]
    public partial class WSQOLTRANSFERENCIAESTOQUEBAIXA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime DATA_HORA_LANCAMENTO { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SEQ_LANCAMENTO { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public int? QTD_TRANSFERIDA { get; set; }

        public int? ATUALIZACAO { get; set; }

        public int? DOCUMENTO { get; set; }

        [StringLength(100)]
        public string LOCAL_ORIGEM { get; set; }

        [StringLength(100)]
        public string LOCAL_DESTINO { get; set; }

        [StringLength(100)]
        public string OBSERVACAO { get; set; }

        public int STATUS_ATUALIZACAO { get; set; }

        [StringLength(200)]
        public string MENSAGEM_ERRO_ERP { get; set; }
    }
}
