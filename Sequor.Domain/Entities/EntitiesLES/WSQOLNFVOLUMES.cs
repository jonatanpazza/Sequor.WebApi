namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLNFVOLUMES
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_NF { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SEQUENCIA { get; set; }

        [Key]
        [Column(Order = 2)]
        public long ID { get; set; }

        [StringLength(50)]
        public string ESPECIE { get; set; }

        public int? QUANTIDADE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PESO_LIQUIDO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? PESO_BRUTO { get; set; }

        [StringLength(50)]
        public string ORIGEM { get; set; }
    }
}
