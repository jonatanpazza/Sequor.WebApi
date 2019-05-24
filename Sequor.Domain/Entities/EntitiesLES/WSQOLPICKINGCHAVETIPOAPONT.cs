namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLPICKINGCHAVETIPOAPONT")]
    public partial class WSQOLPICKINGCHAVETIPOAPONT
    {
        public long ID { get; set; }

        [StringLength(200)]
        public string DESCRICAO { get; set; }
    }
}
