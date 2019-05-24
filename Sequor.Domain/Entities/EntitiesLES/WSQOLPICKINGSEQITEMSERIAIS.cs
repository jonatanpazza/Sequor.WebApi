namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLPICKINGSEQITEMSERIAIS
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_SEQ { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_SEQ_ITEM { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(200)]
        public string SERIAL { get; set; }

        [Key]
        [Column(Order = 4, TypeName = "numeric")]
        public decimal PESO { get; set; }
    }
}
