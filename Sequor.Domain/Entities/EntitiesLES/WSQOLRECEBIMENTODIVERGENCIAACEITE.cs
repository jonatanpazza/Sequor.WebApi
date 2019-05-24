namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLRECEBIMENTODIVERGENCIAACEITE")]
    public partial class WSQOLRECEBIMENTODIVERGENCIAACEITE
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string CODIGO_RECEBIMENTO { get; set; }

        [StringLength(50)]
        public string NOTADEVOLUCAO { get; set; }

        [StringLength(50)]
        public string FATORGERADOR { get; set; }

        [StringLength(50)]
        public string EMBALAGEM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PESO { get; set; }

        [StringLength(50)]
        public string CODFORNECEDOR { get; set; }

        [StringLength(50)]
        public string NUMERONF { get; set; }

        [StringLength(50)]
        public string SERIE { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        public DateTime? DATAREG { get; set; }

        public int? ID_RECEBIMENTO_DIVERGENCIA { get; set; }
    }
}
