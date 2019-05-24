namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLMODULOSREGRAS
    {
        [Key]
        [Column(Order = 0)]
        public long ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_MODULO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string CODIGO_EXCECAO { get; set; }

        [StringLength(200)]
        public string VALOR_VARCHAR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VALOR_NUMERIC { get; set; }

        public bool? VALOR_BIT { get; set; }

        public bool? HABILITADO { get; set; }
    }
}
