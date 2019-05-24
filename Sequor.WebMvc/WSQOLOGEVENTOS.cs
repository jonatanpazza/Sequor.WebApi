namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLOGEVENTOS
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
        public DateTime DATA_OCORRENCIA { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string EVENTO { get; set; }

        [Key]
        [Column(Order = 4)]
        public long ID { get; set; }

        [StringLength(2000)]
        public string DESCRICAO { get; set; }
    }
}
