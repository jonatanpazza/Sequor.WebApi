namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WSQOLRECEBIMENTOVOLUMES
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CODIGO_RECEBIMENTO { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string CODIGO_RASTREABILIDADE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE { get; set; }

        public DateTime? DATA_OCORRENCIA { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        public DateTime? DATA_VENCIMENTO { get; set; }

        public long? STATUS { get; set; }

        public long? ID_SEGREGADO { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ID { get; set; }

        [StringLength(50)]
        public string LOCAL_DESTINO { get; set; }

        [StringLength(50)]
        public string TIPO_ESTOQUE { get; set; }

        public int? CONTAGEM { get; set; }

        [StringLength(50)]
        public string CATEGORIA_CUSTO { get; set; }

        [StringLength(50)]
        public string NF { get; set; }

        public long? ID_FORNECEDOR { get; set; }

        [StringLength(50)]
        public string REQUISITANTE { get; set; }
    }
}
