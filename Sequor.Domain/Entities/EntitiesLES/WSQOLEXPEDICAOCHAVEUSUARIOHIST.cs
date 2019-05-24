namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLEXPEDICAOCHAVEUSUARIOHIST")]
    public partial class WSQOLEXPEDICAOCHAVEUSUARIOHIST
    {
        public long ID { get; set; }

        public long? ID_CHAVE_USUARIO { get; set; }

        [StringLength(50)]
        public string ID_CHAVE { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        [StringLength(50)]
        public string USUARIO_ACAO { get; set; }

        public DateTime? DATA_OCORRENCIA { get; set; }

        [StringLength(250)]
        public string OBSERVACAO { get; set; }
    }
}
