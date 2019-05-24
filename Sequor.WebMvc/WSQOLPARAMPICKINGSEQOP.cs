namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLPARAMPICKINGSEQOP")]
    public partial class WSQOLPARAMPICKINGSEQOP
    {
        public long ID { get; set; }

        public long? ID_SEQ { get; set; }

        public DateTime? DATA_SEPARACAO { get; set; }

        public DateTime? DATA_SEPARACAO_TERMINO { get; set; }

        public DateTime? DATA_PROCESSO_INICIO { get; set; }

        public DateTime? DATA_PROCESSO_FIM { get; set; }

        [StringLength(50)]
        public string CENTRO { get; set; }

        [StringLength(10)]
        public string OPERACAO { get; set; }
    }
}
