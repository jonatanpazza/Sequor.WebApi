namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLENDERECO")]
    public partial class WSQOLENDERECO
    {
        [Key]
        public long ID_ENDERECO { get; set; }

        [StringLength(100)]
        public string RUA { get; set; }

        [StringLength(100)]
        public string BAIRRO { get; set; }

        [StringLength(100)]
        public string CIDADE { get; set; }

        [StringLength(100)]
        public string PAIS { get; set; }

        public int? NUMERO { get; set; }
    }
}
