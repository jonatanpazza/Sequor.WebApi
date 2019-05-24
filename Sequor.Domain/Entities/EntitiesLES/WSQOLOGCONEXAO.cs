namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLOGCONEXAO")]
    public partial class WSQOLOGCONEXAO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string LINHA_MONTAGEM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ESTACAO { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime DATA_OCORRENCIA_INICIAL { get; set; }

        [Key]
        [Column(Order = 3)]
        public long ID { get; set; }

        public int? VALOR { get; set; }

        public DateTime? DATA_OCORRENCIA_FINAL { get; set; }

        public int? STATUS { get; set; }

        public int? TEMPO_CICLO { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        public DateTime? DATA_SINCRONIZACAO { get; set; }
    }
}
