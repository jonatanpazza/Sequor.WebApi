namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLPICKINGRESTRICAOQTDMAX")]
    public partial class WSQOLPICKINGRESTRICAOQTDMAX
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QTD_MAX_ITENS_PICKING { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QTD_MAX_LOCAIS_SUGERIDOS { get; set; }
    }
}
