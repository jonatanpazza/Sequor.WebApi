namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLEXPEDICAOCHAVEUSUARIO")]
    public partial class WSQOLEXPEDICAOCHAVEUSUARIO
    {
        public long ID { get; set; }

        public long? ID_CHAVE { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }
    }
}
