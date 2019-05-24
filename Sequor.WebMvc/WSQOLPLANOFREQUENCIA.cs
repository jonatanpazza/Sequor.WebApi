namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLPLANOFREQUENCIA")]
    public partial class WSQOLPLANOFREQUENCIA
    {
        [Key]
        public int CODIGO_PLANO_FREQUENCIA { get; set; }

        [Required]
        [StringLength(100)]
        public string DESCRICAO_PLANO_FREQUENCIA { get; set; }

        public DateTime? DATA_VIGENCIA_INICIAL { get; set; }

        public DateTime? DATA_VIGENCIA_FINAL { get; set; }

        public int? TIPO_RECORRENCIA { get; set; }

        public int? RECORRENCIA { get; set; }

        [StringLength(500)]
        public string CONDICAO { get; set; }
    }
}
