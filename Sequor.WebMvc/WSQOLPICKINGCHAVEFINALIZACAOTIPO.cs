namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLPICKINGCHAVEFINALIZACAOTIPO")]
    public partial class WSQOLPICKINGCHAVEFINALIZACAOTIPO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CODIGO { get; set; }

        [StringLength(50)]
        public string DESCRICAO { get; set; }

        [StringLength(100)]
        public string DESCRICAO_EXTENDIDA { get; set; }
    }
}
