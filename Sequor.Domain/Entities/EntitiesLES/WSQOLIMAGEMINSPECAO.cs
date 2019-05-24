namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLIMAGEMINSPECAO")]
    public partial class WSQOLIMAGEMINSPECAO
    {
        [Key]
        public long ID_IMAGEM_INSPECAO { get; set; }

        [StringLength(100)]
        public string IMAGEM_INSPECAO { get; set; }
    }
}
