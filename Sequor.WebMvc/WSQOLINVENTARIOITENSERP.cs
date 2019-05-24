namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLINVENTARIOITENSERP")]
    public partial class WSQOLINVENTARIOITENSERP
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_INVENTARIO { get; set; }

        [Key]
        [Column(Order = 1)]
        public long ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string UNIDADE_MEDIDA { get; set; }

        [StringLength(50)]
        public string RECONTAGEM { get; set; }

        [StringLength(50)]
        public string TIPO_ESTOQUE { get; set; }
    }
}
