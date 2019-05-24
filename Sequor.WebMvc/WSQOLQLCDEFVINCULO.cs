namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLQLCDEFVINCULO")]
    public partial class WSQOLQLCDEFVINCULO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CODIGO_FORNECEDOR { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string MODULO { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string PLANO_INSPECAO { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [StringLength(50)]
        public string ESTRATEGIA { get; set; }

        public bool? HABILITADO { get; set; }
    }
}
