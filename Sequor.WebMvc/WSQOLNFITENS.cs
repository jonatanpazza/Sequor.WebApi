namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLNFITENS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long ID_NF { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SEQUENCIA { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        [StringLength(120)]
        public string DESCRICAO_PRODUTO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? VALOR { get; set; }

        [StringLength(10)]
        public string UNIDADE { get; set; }

        [StringLength(500)]
        public string INFORMACAO_ADICIONAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_VINCULADA { get; set; }

        public int? STATUS { get; set; }

        [StringLength(50)]
        public string UNIDADE_ORIGINAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_ORIGINAL { get; set; }
    }
}
