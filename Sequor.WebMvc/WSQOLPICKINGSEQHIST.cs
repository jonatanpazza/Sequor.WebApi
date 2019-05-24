namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLPICKINGSEQHIST")]
    public partial class WSQOLPICKINGSEQHIST
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CHAVE { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CODIGO_RASTREABILIDADE { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime DATA_PROCESSO { get; set; }

        public long ID { get; set; }

        [StringLength(50)]
        public string KIT { get; set; }

        public int? SEQUENCIAMENTO { get; set; }

        public int? SEQUENCIAMENTO_ORIGINAL { get; set; }

        public int? STATUS { get; set; }

        [StringLength(50)]
        public string USUARIO_PICKING { get; set; }

        public DateTime? DATA_INCLUSAO { get; set; }

        [StringLength(50)]
        public string PRIORIDADE_A { get; set; }

        [StringLength(50)]
        public string PRIORIDADE_B { get; set; }

        [StringLength(50)]
        public string PRIORIDADE_C { get; set; }
    }
}
