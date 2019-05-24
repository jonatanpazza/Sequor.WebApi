namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLKANBANMOV")]
    public partial class WSQOLKANBANMOV
    {
        public long ID { get; set; }

        public long? ID_KANBAN { get; set; }

        [StringLength(50)]
        public string CODIGO_CARTAO { get; set; }

        [StringLength(50)]
        public string LOCAL_RECIPIENTE { get; set; }

        [StringLength(50)]
        public string LOCAL_ALOCACAO { get; set; }

        public int? STATUS { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_ATUAL { get; set; }

        public DateTime? DATA_OCORRENCIA { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }
    }
}
