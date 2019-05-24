namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    [Table("WSQOLUNIDADESCONVERSAO")]
    public partial class WSQOLUNIDADESCONVERSAO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string UNIDADE_FROM { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string UNIDADE_TO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? FATOR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? TOLERANCIA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? OFFSET { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }
    }
}
