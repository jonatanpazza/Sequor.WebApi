namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLRESTRICAOENDERECO")]
    public partial class WSQOLRESTRICAOENDERECO
    {
        [Key]
        public long ID_REST_ENDERECO { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }
    }
}
