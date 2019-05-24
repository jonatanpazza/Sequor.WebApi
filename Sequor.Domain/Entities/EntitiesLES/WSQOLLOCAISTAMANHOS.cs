namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    //using System.Data.Entity.Spatial;

    public partial class WSQOLLOCAISTAMANHOS
    {
        [Key]
        public long ID_TAMANHO_LOCAL { get; set; }

        [StringLength(50)]
        public string TAMANHO_LOCAL { get; set; }

        public int? ORDENACAO_TAMANHO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? ALTURA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LARGURA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? COMPRIMENTO { get; set; }

        public int? ORDENACAO_TAMANHO_MAXIMO { get; set; }
    }
}
