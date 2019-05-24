namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLSSTOREMOVDEBITOCOMPONENTESERROS_STATUS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string STATUS { get; set; }

        [StringLength(500)]
        public string DESCRICAO { get; set; }
    }
}
