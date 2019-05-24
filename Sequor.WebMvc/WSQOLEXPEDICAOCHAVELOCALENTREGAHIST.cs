namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLEXPEDICAOCHAVELOCALENTREGAHIST")]
    public partial class WSQOLEXPEDICAOCHAVELOCALENTREGAHIST
    {
        public long ID { get; set; }

        public long? ID_CHAVE_LOCAL { get; set; }

        public long? ID_CHAVE { get; set; }

        public long? ID_LOCAL { get; set; }

        [StringLength(50)]
        public string CODIGO_LOCAL { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        public DateTime? DATA_OCORRENCIA { get; set; }

        [StringLength(250)]
        public string OBSERVACAO { get; set; }
    }
}
