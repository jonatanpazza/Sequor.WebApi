namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLRECEBIMENTOCONTAGENS
    {
        [Required]
        [StringLength(50)]
        public string CODIGO_RECEBIMENTO { get; set; }

        [Required]
        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        public int CONTAGEM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_CONTAGEM { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        public DateTime? DATA_OCORRENCIA { get; set; }

        public long ID { get; set; }

        public int? STATUS_CONTAGEM { get; set; }

        [Required]
        [StringLength(50)]
        public string TIPO_ESTOQUE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_ESPERADA { get; set; }

        [Required]
        [StringLength(50)]
        public string CATEGORIA_CUSTOS { get; set; }

        public int? QUALIDADE_UNIDADE_NEGOCIO_ERP { get; set; }
    }
}
