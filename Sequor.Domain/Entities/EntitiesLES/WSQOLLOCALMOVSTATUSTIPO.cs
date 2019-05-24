namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLLOCALMOVSTATUSTIPO")]
    public partial class WSQOLLOCALMOVSTATUSTIPO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STATUS { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string DESCRICAO { get; set; }
    }
}
