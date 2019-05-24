namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLPICKINGMOV")]
    public partial class WSQOLPICKINGMOV
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_SEQ { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime DATA_OCORRENCIA_INICIAL { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        public DateTime? DATA_OCORRENCIA_FINAL { get; set; }

        public int? TEMPO_CICLO { get; set; }

        [StringLength(50)]
        public string USUARIO_PAGAMENTO { get; set; }

        public int? STATUS { get; set; }

        [StringLength(50)]
        public string VERSAO_TABLET_ULTIMA_MOVIMENTACAO { get; set; }

        [StringLength(100)]
        public string PRIORIDADE_A { get; set; }

        [StringLength(500)]
        public string MSG_ERRO { get; set; }

        [StringLength(50)]
        public string CHAVE { get; set; }

        [StringLength(50)]
        public string GRUPO { get; set; }
    }
}
