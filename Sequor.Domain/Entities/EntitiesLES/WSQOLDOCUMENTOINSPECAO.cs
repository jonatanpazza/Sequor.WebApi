namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLDOCUMENTOINSPECAO")]
    public partial class WSQOLDOCUMENTOINSPECAO
    {
        [Key]
        public long ID_DOC_INSPECAO { get; set; }

        [StringLength(100)]
        public string DOC_INSPECAO { get; set; }
    }
}
