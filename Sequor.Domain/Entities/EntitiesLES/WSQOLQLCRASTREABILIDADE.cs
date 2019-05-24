namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLQLCRASTREABILIDADE")]
    public partial class WSQOLQLCRASTREABILIDADE
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string CHAVE { get; set; }

        [StringLength(50)]
        public string REGRA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VALOR { get; set; }

        [StringLength(50)]
        public string ATRIBUTO { get; set; }

        public DateTime? DATA_OCORRENCIA { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        public bool? STATUS { get; set; }

        public long? ID_FOTOS { get; set; }
    }
}
