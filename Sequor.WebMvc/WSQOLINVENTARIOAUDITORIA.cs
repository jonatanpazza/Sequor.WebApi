namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLINVENTARIOAUDITORIA")]
    public partial class WSQOLINVENTARIOAUDITORIA
    {
        [Key]
        public long ID_AUDITORIA { get; set; }

        public int? TIPO_AUDITORIA { get; set; }

        public long? ID_CONTAGEM { get; set; }

        public long? ID_TAREFA { get; set; }

        public long? ID_INVENTARIO { get; set; }

        public long? ID_ITEM_INVENTARIO { get; set; }

        [StringLength(50)]
        public string NUMERO_INVENTARIO { get; set; }

        [StringLength(50)]
        public string CHAVE { get; set; }

        [StringLength(50)]
        public string DEPOSITO { get; set; }

        [StringLength(50)]
        public string CODIGO_LOCAL { get; set; }

        [StringLength(50)]
        public string CODIGO_RASTREABILIDADE { get; set; }

        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        [StringLength(50)]
        public string UNIDADE_CONTAGEM { get; set; }

        public int? TIPO_ESTOQUE_LES { get; set; }

        public DateTime? DATA_INICIAL { get; set; }

        public DateTime? DATA_FINAL { get; set; }

        [StringLength(50)]
        public string NUMERO_CONTAGEM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE_CONTADA { get; set; }

        [StringLength(50)]
        public string USUARIO { get; set; }

        public DateTime? DATA_OCORRENCIA { get; set; }

        [StringLength(50)]
        public string VERSION { get; set; }
    }
}
