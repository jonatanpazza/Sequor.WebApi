namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLCARGAHIST")]
    public partial class WSQOLCARGAHIST
    {
        public int ID { get; set; }

        public long ID_CARGA { get; set; }

        public int CODIGO { get; set; }

        [Required]
        [StringLength(20)]
        public string USUARIO { get; set; }

        public DateTime DATA { get; set; }
    }
}
