namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLINVENTARIO")]
    public partial class WSQOLINVENTARIO
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID_INVENTARIO { get; set; }

        [Key]
        [StringLength(50)]
        public string NUMERO_INVENTARIO { get; set; }

        public DateTime? DATA_DOCUMENTO { get; set; }

        public DateTime? DATA_PREV_CONTAGEM { get; set; }

        [StringLength(50)]
        public string EXERCICIO { get; set; }

        [StringLength(50)]
        public string CENTRO { get; set; }

        [StringLength(50)]
        public string DEPOSITO { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        [StringLength(50)]
        public string STATUS_CONTAGEM { get; set; }

        [StringLength(50)]
        public string STATUS_BAIXA { get; set; }

        public bool? BLOQUEIO_REGISTROS { get; set; }

        public int TIPO_INVENTARIO { get; set; }
    }
}
