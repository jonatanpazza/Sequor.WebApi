namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLQLCTIPOFOTO")]
    public partial class WSQOLQLCTIPOFOTO
    {
        [Key]
        public long ID_TIPO_FOTO { get; set; }

        [StringLength(100)]
        public string DESCRICAO { get; set; }

        public int? TIRAR_FOTO { get; set; }

        public int? QUANTIDADE_FOTOS { get; set; }
    }
}
