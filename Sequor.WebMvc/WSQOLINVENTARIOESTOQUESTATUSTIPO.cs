namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLINVENTARIOESTOQUESTATUSTIPO")]
    public partial class WSQOLINVENTARIOESTOQUESTATUSTIPO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_STATUS { get; set; }

        [StringLength(50)]
        public string DESCRICAO { get; set; }
    }
}