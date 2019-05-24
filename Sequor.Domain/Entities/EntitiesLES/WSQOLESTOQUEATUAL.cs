namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLESTOQUEATUAL")]
    public partial class WSQOLESTOQUEATUAL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string LOCAL { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string CODIGO_RASTREABILIDADE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE { get; set; }

        public DateTime? DATA_INCLUSAO { get; set; }

        public DateTime? DATA_ULTIMA_MOVIMENTACAO { get; set; }

        [StringLength(50)]
        public string USUARIO_ULTIMA_MOVIMENTACAO { get; set; }

        public int? STATUS_MOVIMENTACAO { get; set; }

        [StringLength(100)]
        public string MENSAGEM_STATUS_MOVIMENTACAO { get; set; }

        [StringLength(50)]
        public string LOCAL_ORIGEM_MOV { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        public int? NIVEL { get; set; }
    }
}
