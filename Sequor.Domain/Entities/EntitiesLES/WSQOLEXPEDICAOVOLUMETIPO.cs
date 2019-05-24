namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLEXPEDICAOVOLUMETIPO")]
    public partial class WSQOLEXPEDICAOVOLUMETIPO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TIPO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string DESCRICAO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(400)]
        public string DESCRICAO_EXTENDIDA { get; set; }
    }
}
