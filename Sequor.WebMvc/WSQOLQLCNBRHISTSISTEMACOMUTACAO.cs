namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLQLCNBRHISTSISTEMACOMUTACAO")]
    public partial class WSQOLQLCNBRHISTSISTEMACOMUTACAO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_VINCULO { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime DATA_OCORRENCIA { get; set; }

        [StringLength(50)]
        public string REGIME_INSPECAO_ANTIGO { get; set; }

        [StringLength(50)]
        public string REGIME_INSPECAO_NOVO { get; set; }

        public int? MOTIVO { get; set; }

        [StringLength(100)]
        public string DESCRICAO_MOTIVO { get; set; }
    }
}
