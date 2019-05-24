namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLRECEBIMENTOVOLUMESITENSSTATUS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_STATUS { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string DESCRICAO { get; set; }
    }
}
