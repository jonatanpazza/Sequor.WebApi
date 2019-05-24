namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLLOCAISPRODUTOS
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CODIGO_LOCAL { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        public int? TIPO_CONSUMO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ESTOQUE_MINIMO { get; set; }

        public bool? PORCENTAGEM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_REPOSICAO_CRITICA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_REPOSICAO_MINIMA { get; set; }
    }
}
