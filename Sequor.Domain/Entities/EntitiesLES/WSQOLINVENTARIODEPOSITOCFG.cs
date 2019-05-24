namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLINVENTARIODEPOSITOCFG")]
    public partial class WSQOLINVENTARIODEPOSITOCFG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string DEPOSITO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string LOCAL_QUARENTENA { get; set; }

        [StringLength(100)]
        public string CHAVE_INVENTARIO { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TIPO_INVENTARIO { get; set; }

        public DateTime DATETIME { get; set; }

        public int RECONTAGEM_AUTOMATICA { get; set; }

        public int LTM_PANEL { get; set; }

        public int? NUMERO_CONTAGENS { get; set; }

        public int? GERAR_RECONTAGEM { get; set; }
    }
}
