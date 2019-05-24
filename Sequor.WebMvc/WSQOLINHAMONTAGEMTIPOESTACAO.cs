namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLINHAMONTAGEMTIPOESTACAO")]
    public partial class WSQOLINHAMONTAGEMTIPOESTACAO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODIGO { get; set; }

        [StringLength(50)]
        public string TIPO_ESTACAO { get; set; }
    }
}
