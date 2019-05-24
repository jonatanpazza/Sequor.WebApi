namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLQLCNBRDEFCODIGOLITERAL")]
    public partial class WSQOLQLCNBRDEFCODIGOLITERAL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string NIVEL_INSPECAO { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TAMANHO_LOTE_MIN { get; set; }

        public int? TAMANHO_LOTE_MAX { get; set; }

        [StringLength(1)]
        public string CODIGO_LITERAL { get; set; }
    }
}
