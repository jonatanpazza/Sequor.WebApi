namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLCOMPONENTEMEDICAO")]
    public partial class WSQOLCOMPONENTEMEDICAO
    {
        [Key]
        public int ID_COMPONENTE { get; set; }

        [StringLength(100)]
        public string COMPONENTE { get; set; }
    }
}
