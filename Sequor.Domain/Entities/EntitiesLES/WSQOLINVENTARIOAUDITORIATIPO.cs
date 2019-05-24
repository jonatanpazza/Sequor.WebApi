namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLINVENTARIOAUDITORIATIPO")]
    public partial class WSQOLINVENTARIOAUDITORIATIPO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_AUDITORIA_TIPO { get; set; }

        [StringLength(50)]
        public string DESCRICAO { get; set; }

        [StringLength(300)]
        public string DESCRICAO_EXTENDIDA { get; set; }
    }
}
