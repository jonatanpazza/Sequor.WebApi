namespace Sequor.WebMvc
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("WSQOLINVENTARIOITENSHIST")]
    public partial class WSQOLINVENTARIOITENSHIST
    {
        [Key]
        public long ID_HIST { get; set; }

        public long ID_INVENTARIO_ITEM { get; set; }

        public long ID_INVENTARIO { get; set; }

        [Required]
        [StringLength(50)]
        public string ITEM_INVENTARIO { get; set; }

        [Required]
        [StringLength(50)]
        public string NUMERO_INVENTARIO { get; set; }

        [Required]
        [StringLength(50)]
        public string CODIGO_PRODUTO { get; set; }

        public int TIPO_ESTOQUE_LES { get; set; }

        [Required]
        [StringLength(50)]
        public string UNIDADE_MEDIDA { get; set; }

        [StringLength(50)]
        public string DOC_RECONTAGEM { get; set; }

        [StringLength(50)]
        public string CODIGO_FORNECEDOR { get; set; }

        [StringLength(50)]
        public string ESTOQUE_ESPECIAL { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? QUANTIDADE { get; set; }

        [StringLength(50)]
        public string CONTAGEM_ZERO { get; set; }

        [StringLength(50)]
        public string CONTADO { get; set; }

        [StringLength(50)]
        public string CONTAGEM_APROVADA { get; set; }

        [StringLength(50)]
        public string RECONTAGEM { get; set; }

        [StringLength(50)]
        public string ITEM_ELIMINADO { get; set; }

        [StringLength(50)]
        public string DEPOSITO { get; set; }

        public long STATUS_ID { get; set; }

        public long STATUS_ID_INVENTARIO_ITEM { get; set; }

        public int? STATUS_STATUS { get; set; }

        [StringLength(50)]
        public string STATUS_USUARIO { get; set; }

        public DateTime? STATUS_DATA_OCORRENCIA { get; set; }

        public int? STATUS_STATUS_ESTOQUE { get; set; }

        public int? STATUS_TIPO_ESTOQUE_LES { get; set; }

        [StringLength(500)]
        public string STATUS_MSG_ERRO { get; set; }

        public int? STATUS_NUMERO_TENTATIVAS { get; set; }
    }
}
