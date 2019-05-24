namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLQLCSEGREGADOS
    {
        public long ID { get; set; }

        public long? ID_VINCULO { get; set; }

        [StringLength(50)]
        public string CODIGO_RASTREABILIDADE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_AMOSTRA { get; set; }

        public int? STATUS { get; set; }

        public DateTime? DATA_OCORRENCIA { get; set; }

        [StringLength(50)]
        public string USUARIO_SEGREGACAO { get; set; }

        [StringLength(50)]
        public string USUARIO_INSPECAO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_AMOSTRA_OK { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_AMOSTRA_NOK { get; set; }

        public DateTime? DATA_INSPECAO { get; set; }
    }
}
